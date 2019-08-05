using UnityEngine;
using System.Collections;

public class DestroyByyContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private Gamecontroller gamecontroller;

	void Start ()
	{
		GameObject gamecontrollerObject = GameObject.FindGameObjectWithTag ("Gamecontroller");
		if (gamecontrollerObject != null)
		{
			gamecontroller = gamecontrollerObject.GetComponent <Gamecontroller>();
		}
		if (gamecontroller == null)
		{
			Debug.Log ("Cannot find 'Gamecontroller' script");
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary" || other.tag == "enemy")
		{
			return;
		}

		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}

		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gamecontroller.GameOver();
		}
		
		gamecontroller.AddScore(scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}