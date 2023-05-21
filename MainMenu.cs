using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start() {
        AudioManager.Instance.PlayMusic("Theme");
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ToggleMusic() {
        AudioManager.Instance.ToggleMusic();
    }

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
}