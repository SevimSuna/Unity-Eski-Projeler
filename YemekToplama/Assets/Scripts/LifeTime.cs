using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTime : MonoBehaviour
{
    public Text timer;
    public Image[] can;
    public AudioClip lifeSound;

    public int life;
    public float timerS;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerS += Time.deltaTime;
        timer.text = "Time: " + timerS.ToString("0");
    }
    public void loseLife()
    {
        life--;
        GetComponent<AudioSource>().PlayOneShot(lifeSound);
    }
}
