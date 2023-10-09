using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AppleCount : MonoBehaviour
{
    private int score;
    public Text scoreText;
    
    void Start()
    {
        score = 0;
    }
    private void Update()
    {
        if (score == 10)
        {
            scoreText.text = "Muy buen Trabajo" + score;
        }
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            score++;
            
            scoreText.text = "Score =" + score;

        }
    }









}



