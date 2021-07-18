using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basket : MonoBehaviour
{
    Scene currentScene;
    public bool trueFood;
    public AudioClip basketSound;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        trueFood = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7 ||collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
        }
        if (currentScene.buildIndex == 2)
        {
            if (collision.gameObject.layer == 6 || collision.gameObject.layer == 7)
            {
                GetComponent<AudioSource>().PlayOneShot(basketSound);
                trueFood = true;
            }
        }
        if(currentScene.buildIndex == 4)
        {
            if (collision.gameObject.layer == 6)
            {
                GetComponent<AudioSource>().PlayOneShot(basketSound);
                trueFood = true;
            }
            if (collision.gameObject.layer == 7)
            {
                trueFood = false;
            }
            
        }
        if(currentScene.buildIndex == 6)
        {
            if(collision.gameObject.tag == "Carrot")
            {
                GetComponent<AudioSource>().PlayOneShot(basketSound);
                trueFood = true;
            }
            else if (collision.gameObject.tag == "Floor")
            {
                
            }
            else
            {
                trueFood = false;
            }
        }
        if (currentScene.buildIndex == 8)
        {
            if (collision.gameObject.layer == 7 || collision.gameObject.layer == 8)
            {
                GetComponent<AudioSource>().PlayOneShot(basketSound);
                trueFood = true;
            }
            else if (collision.gameObject.tag == "Floor")
            {

            }
            else
            {
                trueFood = false;
            }
        }

    }

}
