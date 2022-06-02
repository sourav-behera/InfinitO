using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    
   public int score, highscore;
   public Transform player;
   public TextMeshProUGUI _score;
   public TextMeshProUGUI _highscore;

   public static ScoreManager scoreManager;

   
   private void Start() {
        if (scoreManager == null ) scoreManager = this;
       _score.text = "SC: 0";
       _highscore.text = "HI: "+PlayerPrefs.GetInt("Highscore").ToString();
   }
   private void Update() {
       if (player.position.y > 0){
           if (player.position.y*100 > score){
                score = (int)(player.position.y*100);
                _score.text = "SC: "+((int)(player.position.y*100)).ToString();
                if (score > PlayerPrefs.GetInt("Highscore")){
                    PlayerPrefs.SetInt("Highscore", score);
                    _highscore.text = "HI: "+score.ToString();
                }
            }
            
        }
    }

}
