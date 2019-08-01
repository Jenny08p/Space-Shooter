using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LoseEvent : MonoBehaviour
{
       public AudioClip loseclip;

       public AudioSource winsong;

  void Start()
    {
        GetComponent<GameController>().loseEvent.AddListener(PlayWhenlost);
    }

    // Update is called once per frame
  
        private void PlayWhenlost()
    {   
        winsong.Stop();
        winsong.clip = loseclip; 
        winsong.Play(); 
        Time.timeScale = 0f;
    }
    
}
