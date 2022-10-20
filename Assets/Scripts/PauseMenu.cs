using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }

    }
    public void TogglePauseGame()
    {
        //pause time
        isPaused = !isPaused;

        //menu.SetActive(!menu.activeInHierarchy);
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}