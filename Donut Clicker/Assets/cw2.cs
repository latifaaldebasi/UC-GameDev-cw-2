using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cw2 : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    int inc = 1;
    public Text incText;

    int price = 5;
    public Text priceText;

    public void ScoreUp()
    {
        score += inc ;
        scoreText.text = score + " "; 
        } 
      
     public void Shop()
     {
        if(score>=5)
        {
            score -= 5;
            inc += 1;
            scoreText.text = score.ToString();
            incText.text = " inc: " + inc;
            priceText.text = "price: "+ price;
            
            }
     }

}
