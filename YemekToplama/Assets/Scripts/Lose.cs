using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public GameObject lostPanel;
    public Text sonYazi;
    void Start()
    {
        lostPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        lostPanel.SetActive(true);
    }
}
