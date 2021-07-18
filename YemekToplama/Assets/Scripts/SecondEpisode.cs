using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondEpisode : MonoBehaviour
{
    // Sadece Meyve

    RandomFood callFood;
    Basket isTrueFood;
    LifeTime lifeCount;
    Lose lostGame;
    Scene currentScene;

    public Text episodeDuty;
    public Text skor;

    int skorInt;

    void Start()
    {
        episodeDuty.text = "Sepeti sadece meyvelerle doldur!";
        currentScene = SceneManager.GetActiveScene();
        callFood = GameObject.FindGameObjectWithTag("Basket").GetComponent<RandomFood>();
        isTrueFood = GameObject.FindGameObjectWithTag("Basket").GetComponent<Basket>();
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
    private void FixedUpdate()
    {
        if (isTrueFood.trueFood == false)
        {
            lifeCount.loseLife();
            Destroy(lifeCount.can[lifeCount.life]);
            if (lifeCount.life > 0)
            {
                isTrueFood.trueFood = true;
            }
            else
            {
                lostGame.GameOver();
                Time.timeScale = 0;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            lifeCount.loseLife();
            Destroy(lifeCount.can[lifeCount.life]);
            if (lifeCount.life > 0)
            {
                callFood.SpawnWaves();
            }
            else
            {
                lostGame.GameOver();
                Time.timeScale = 0;
            }
        }
        else if(collision.gameObject.layer == 7)
        {
            if (lifeCount.life >= 0)
            {
                callFood.SpawnWaves();
            }
        }
    }
    
}
