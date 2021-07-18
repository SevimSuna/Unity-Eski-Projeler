using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{

    float counter;

    public GameObject counterPanel;

    public Text counterText;

    Scene currentScene;


    void Start()
    {
        counterPanel.SetActive(true);
        currentScene = SceneManager.GetActiveScene();
        counter = 3f;
    }

    void Update()
    {
        
        if(counter < 0)
        {
            counterPanel.SetActive(false);
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
        if(counter >= 0)
        {
            Time.timeScale = 1;
            counter -= Time.deltaTime;
            counterText.text = counter.ToString("0");
        }
    }
}
