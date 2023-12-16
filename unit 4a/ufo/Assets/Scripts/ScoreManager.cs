using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro name spaced added to access the librarys for UI
public class ScoreManager : MonoBehaviour
{
   public int score; // keep our score value
   public TextMeshProUGUI scoreText; // Visual text element to be modified
   public void IncreaseScore(int amount)
   {
      score += amount;
      UpdateScoreText();
   }

   public void DecreaseScore(int amount)
   {
      score -= amount;
      UpdateScoreText();
   }

   public void UpdateScoreText()
   {
      scoreText.text = "Score: "+ score;
   }
}
