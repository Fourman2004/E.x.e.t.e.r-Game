using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReadScore : MonoBehaviour
{
    public int score, misses, missCap;
    public Text scoreText, misstext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score:" + score.ToString());
        misstext.text = ("Misses:" + misses.ToString());
    }

    public void UpdateScore()
    {
        score++;
    }

    public void UpdateMisses()
    {
        if (misses != missCap)
        {
            misses++;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
