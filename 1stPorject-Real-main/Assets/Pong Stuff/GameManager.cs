using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Gamemanager1 : MonoBehaviour
{
   [Header("Ball")]
   public GameObject ball;

   [Header("Player 1")]
   public GameObject player1Paddle;
   public GameObject player1Goal;
   [Header("Player 2")]
   public GameObject player2Paddle;
   public GameObject player2Goal;

   [Header("Score UI")]
   public GameObject Player1Text;
   public GameObject Player2Text;

   public Timer Music;
   public Timer done;


   private int Player1Score;
   private int Player2Score;

   void Update()
   {
      if(done.gamedone == true)
      {
         ball.SetActive(false);
      }
   }




   public void Player1Scored()
   {
      if(Player1Score != 9)
      {
         Player1Score++;
         Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
         ResetPosition();
      }else if (Player1Score == 9)
      {
         Player1Text.GetComponent<TextMeshProUGUI>().text = "WIN";
         Music.MusicPlayer.Stop();
         done.gamedone = true;
      }
    
   }

    public void Player2Scored()
   {
       if(Player2Score != 9 )
      {
         Player2Score++;
         Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
         ResetPosition();
      }else if (Player2Score == 9)
      {
         Player2Text.GetComponent<TextMeshProUGUI>().text = "WIN";
         Music.MusicPlayer.Stop();
         done.gamedone = true;
      }
    
   }

   private void ResetPosition()
   {
    ball.GetComponent<Ball>().Reset();
    player1Paddle.GetComponent<Paddle>().Reset();
    player2Paddle.GetComponent<Paddle>().Reset();
   }

   // public void GameFinished()
   // {
   //    if(Input.GetKeyDown(KeyCode.Space) && gamedone == true)
   //    {
   //       SceneManager.LoadScene("MenuScene");
   //    }
   // }



}
