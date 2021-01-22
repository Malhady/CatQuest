using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
        [SerializeField] private AudioSource finishSound;

        private ScoreTracker s;

    // Start is called before the first frame update
    
    void Start()
    {
        s = GameObject.Find("Score").GetComponent<ScoreTracker>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            finishSound.Play();
            SceneManager.LoadScene("WinningScene");
            Score.ScoreCount = s.score;
        }
    }
}
