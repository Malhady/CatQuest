using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public static bool PausedGame = false;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "SampleScene"){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(PausedGame){
                Resume();
            }else{
                Pause();
            }
            }
        }
    }
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; 
        PausedGame = false;
    }
    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; 
        PausedGame = true;
    }
    public void Exit(){
        Debug.Log("You have Exited the Game");
        Application.Quit();
    }
    public void Menu(){
        Pause();
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart(){
        //Debug.Log("Game has Restarted");
        Resume();
        SceneManager.LoadScene("SampleScene");
    }    
    public void StartGame(){
        //Debug.Log("Game has Started");
        SceneManager.LoadScene("SampleScene");
        Time.timeScale=1;
        PausedGame=false;
    }

    

}
