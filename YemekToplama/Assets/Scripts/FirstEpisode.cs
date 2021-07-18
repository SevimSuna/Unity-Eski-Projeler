using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstEpisode : MonoBehaviour
{
    //50 Puan Topla 

    RandomFood callFood;
    LifeTime lifeCount;
    Lose lostGame;
    Scene currentScene;

    public Text episodeDuty;
    public Text skor;

    int skorInt;

    void Start()
    {
        episodeDuty.text = "Sepeti 50 puan yap!";
        currentScene = SceneManager.GetActiveScene();
        callFood = GameObject.FindGameObjectWithTag("Basket").GetComponent<RandomFood>();
        lifeCount = GameObject.FindGameObjectWithTag("Script").GetComponent<LifeTime>();
        lostGame = GameObject.FindGameObjectWithTag("Script").GetComponent<Lose>();
    }
    // Update is called once per frame
    void Update()
    {
        int.TryParse(skor.text, out skorInt);
        if (skorInt >= 50)
        {
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            lifeCount.loseLife();
            Destroy(lifeCount.can[lifeCount.life]);
            if (lifeCount.life > 0)
            {
                
                Debug.Log(lifeCount.life.ToString());
                callFood.SpawnWaves();
            }
            else
            {
                lostGame.GameOver();
                Time.timeScale = 0;
            }
        }
    }
}
