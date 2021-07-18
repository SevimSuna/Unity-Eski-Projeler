using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdEpisode : MonoBehaviour
{
    // Sadece 10 havuc

    RandomFood callFood;
    LifeTime lifeCount;
    Lose lostGame;
    Basket isTrueFood;
    Scene currentScene;

    public Text episodeDuty;
    public Text skor;
    int sayac = 0;

    int skorInt;

    void Start()
    {
        episodeDuty.text = "Sadece havucla doldur!";
        currentScene = SceneManager.GetActiveScene();
        callFood = GameObject.FindGameObjectWithTag("Basket").GetComponent<RandomFood>();
        isTrueFood = GameObject.FindGameObjectWithTag("Basket").GetComponent<Basket>();
        lifeCount = GameObject.FindGameObjectWithTag("Script").GetComponent<LifeTime>();
        lostGame = GameObject.FindGameObjectWithTag("Script").GetComponent<Lose>();
    }
    void Update()
    {
        int.TryParse(skor.text, out skorInt);
        if (skorInt >= 30)
        {
            SceneManager.LoadScene(currentScene.buildIndex + 1);
            /*lostGame.lostPanel.SetActive(true);
            lostGame.sonYazi.text = "Kazandiniz.";*/
            Time.timeScale = 0;
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
        if (collision.gameObject.tag == "Carrot")
        {
            lifeCount.loseLife();
            Destroy(lifeCount.can[lifeCount.life]);
            if (lifeCount.life > 0)
            {
                
            }
            else
            {
                lostGame.GameOver();
                Time.timeScale = 0;
            }
        }
        if(collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
        {
            if (lifeCount.life >= 0)
            {
                
                sayac++;
                if((sayac%3)==0)
                {
                    Debug.Log(sayac.ToString());
                    callFood.SpawnWaves2(3);
                }
                else
                {
                    callFood.SpawnWaves();
                }
            }
        }
    }
}
