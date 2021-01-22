using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueManager : MonoBehaviour
{
    Player p;

    // Start is called before the first frame update
    void Start()
    {

        p = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            p.ScorePoint();
            GameObject.Destroy(gameObject);
        }
    }
}
