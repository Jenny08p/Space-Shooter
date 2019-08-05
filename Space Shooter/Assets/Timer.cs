using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
 
public class Timer : MonoBehaviour
{
    public int timeLeft = 5;
    public Text countdownText;


    void Start()
    {
        StartCoroutine("LoseTime");
    }
 
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);
 
        if (timeLeft <= 0)
        {
            Time.timeScale = 0f; 
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
        }
    }
 
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
         }
          
    }
}