using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public int score;

    public Text scoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreLabel = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScorePoint()
    {
        score++;
        scoreLabel.text = score.ToString();
    }
}
