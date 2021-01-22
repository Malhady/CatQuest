using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float time;

    public Text text_box;

    private bool running;
    
    // Start is called before the first frame update
    void Start()
    {
        time = 100f;
        running = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(time <= 0 && running)
        {
            text_box.text = time.ToString("0.00");
            running = false;
            SceneManager.LoadScene("Deathscene");
        }
        else if (running)
        {
            time -= Time.deltaTime;
            text_box.text = time.ToString("0.00");
        }
    }
}
