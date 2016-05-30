using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Goal : MonoBehaviour {
    public Text scoreText;
    public GameObject explosion;
    private int score;

    void Start()
    {
        score = 0;
    }
    void OnCollisionEnter(Collision other)
    {
        print("memeactivate");
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            Instantiate(explosion, other.transform.position, other.transform.rotation);
            IncrementScore();
            print("meme");
            Time.timeScale = 0.25f;
        }
    }

    void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
