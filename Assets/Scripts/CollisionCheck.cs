using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionCheck : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            UpdateScore(1);
            collision.gameObject.SetActive(false);
            Debug.Log("We hit a BALL. Please give us a SCORE!!!!");
        }
        else
        if (collision.gameObject.CompareTag("Bonus"))
        {
            UpdateScore(10);
            collision.gameObject.SetActive(false);
            Debug.Log("We hit a BALL. Please give us a SCORE!!!!");
        }
        Debug.Log("The object we collided with is " + collision.gameObject.name);
    }

    public void UpdateScore(int scoreValue)
    {   
        score += scoreValue;

        if (score <= 0)
        {
            score = 0;
        }
        Debug.Log("The score now is " + score);
    }

    public int GetScore()
    {
        return score;
    }
    

}
