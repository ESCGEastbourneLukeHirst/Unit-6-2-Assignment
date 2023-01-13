using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject lLightning;
    public GameObject rRaindrops;
    public GameObject ExitApplication;

    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                if(isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        lLightning.SetActive(false);
        rRaindrops.SetActive(false);
        ExitApplication.SetActive(false);
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        lLightning.SetActive(true);
        rRaindrops.SetActive(true);
        ExitApplication.SetActive(true);
    }
    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
