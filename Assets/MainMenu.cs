using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void LoadMenu(){
        GameObject pause = GameObject.Find("PauseCanvas");
        GameObject inv = GameObject.Find("InventoryCanvas");
        GameObject music = GameObject.Find("Music");
        GameObject camera = GameObject.Find("Main Camera");
        Destroy(inv);
        Destroy(pause);
        Destroy(music);
        Destroy(camera);
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }
}
