using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Wintimed : MonoBehaviour
{
    public AudioClip winclip;

    public AudioSource winsong;


    void Start()
    {
        GetComponent<Gamecontroller>().winEvent.AddListener(PlayWhenWin);
        
    }

    private void PlayWhenWin()
    {   
        winsong.Stop();
        winsong.clip = winclip; 
        winsong.Play(); 
        Time.timeScale = 0f;
    }
}