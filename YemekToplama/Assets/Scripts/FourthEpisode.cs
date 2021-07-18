using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FourthEpisode : MonoBehaviour
{
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
        episodeDuty.text = "Taslardan uzak dur!";
        currentScene = SceneManager.GetActiveScene();
        callFood = GameObject.FindGameObjectWithTag("Basket").GetComponent<RandomFood>();
        isTrueFood = GameObject.FindGameObjectWithTag("Basket").GetComponent<Basket>();
        lifeCount = GameObject.FindGameObjectWithTag("Script").GetComponent<LifeTime>();
        lostGame = GameObject.FindGameObjectWithTag("Script").GetComponent<Lose>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
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
        if (collision.gameObject.layer == 8)
        {
            callFood.SpawnWaves();
        }
    }
}
