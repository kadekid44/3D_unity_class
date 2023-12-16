using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreCollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
    }

   
}
