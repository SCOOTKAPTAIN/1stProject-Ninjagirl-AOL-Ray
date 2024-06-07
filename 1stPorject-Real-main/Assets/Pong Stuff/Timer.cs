using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI timerText;
   [SerializeField] float remainingTime;
   [SerializeField] bool IsOvertime = false;

   [SerializeField] public bool gamedone = false;

   [SerializeField] GameObject Return;  

   public AudioSource MusicPlayer;
   public AudioClip OvertimeMusic;  

  public Ball ball;

   void Update()
   {
    if(remainingTime > 0){

        remainingTime -= Time.deltaTime;

    }
    else if (remainingTime < 0 && IsOvertime == false)
    {
        IsOvertime = true;
        ball.speed = 90;
        ball.GetComponent<Ball>().Reset();
        Debug.Log("OVERTIME!");
        remainingTime = 10;
        timerText.color = Color.red;
        MusicPlayer.clip = OvertimeMusic;
        MusicPlayer.Play();  
       
        
        
    }else if (remainingTime < 0 && IsOvertime == true)
    {
        remainingTime = 0;
        gamedone = true;
    }else if (remainingTime < 0 && gamedone == true)
    {
         remainingTime = 0;
    }

    if(gamedone == true)
    {
        timerText.text = "--:--";
        Return.SetActive(true);
    }

    int minutes = Mathf.FloorToInt(remainingTime / 60);
    int seconds = Mathf.FloorToInt(remainingTime % 60);
    timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    
       if(Input.GetKeyDown(KeyCode.Space) && gamedone == true)
       {
          SceneManager.LoadScene("MenuScene");
       }
    
   }

}
