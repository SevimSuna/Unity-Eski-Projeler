using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    public GameObject panel;
    Scene activeScene;
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void menuButton()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    public void xButton()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void continueButton()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void restartButton()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.buildIndex - 1);
    }
    public void homeButton()
    {
        SceneManager.LoadScene("Giris");
    }
    public void quitButton()
    {
        Application.Quit();
    }
}
