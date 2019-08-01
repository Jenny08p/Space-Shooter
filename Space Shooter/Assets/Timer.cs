using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class Timer : MonoBehaviour
{
    public int timeLeft = 5;
    public Text countdownText;

    private bool gameOver;

    Gamecontroller gController;

    void Start()
    {
        StartCoroutine("LoseTime");
        gController = GameObject.FindGameObjectWithTag("GameController").GetComponent<Gamecontroller>();
    }
 
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);
 
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
            gController.GameOver();
        }
    }
 
    IEnumerator LoseTime()
    {
        while (true)
        {
            gameOver = true;
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
          
    }
}