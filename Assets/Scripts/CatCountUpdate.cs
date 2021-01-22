using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatCountUpdate : MonoBehaviour
{

    private Text catCount;
    // Start is called before the first frame update
    void Start()
    {
        catCount = GameObject.Find("catCount").GetComponent<Text>();
        catCount.text = Score.ScoreCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
