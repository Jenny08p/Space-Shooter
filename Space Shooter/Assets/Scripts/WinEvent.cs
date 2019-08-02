using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WinEvent : MonoBehaviour
{
    public AudioClip winclip;

    public AudioSource winsong;

    public Text winText;

    BGScroller BGScroller; 

    void Start()
    {
        GetComponent<GameController>().winEvent.AddListener(PlayWhenWin);
        winText.text = ""; 
        BGScroller = GameObject.FindGameObjectWithTag("Background").GetComponent<BGScroller>();

    }

    private void PlayWhenWin()
    {   
        winText.text = "You Win! Game created by Jenny.";
        winsong.Stop();
        winsong.clip = winclip; 
        winsong.Play(); 
        StartCoroutine(IncreaseOverTime());
        
    }

    
	IEnumerator IncreaseOverTime()
    {
        float speed = 0;
        for (int i = 0; i < 120; i++)
        {
            BGScroller.scrollSpeed = Mathf.SmoothDamp(BGScroller.scrollSpeed, -BGScroller.tileSizeZ/ 5f, ref speed, 0.5f);
            yield return new WaitForSecondsRealtime(0.1f);
        }
    }
}