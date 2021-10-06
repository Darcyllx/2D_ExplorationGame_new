using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collectSound.Play();
        theScore += 10;
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
        Destroy(gameObject);
    }
}
