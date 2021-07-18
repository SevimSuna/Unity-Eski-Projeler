using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HedefGoster : MonoBehaviour
{
    public float mesafe;
    public GameObject yaziGoster;
    void Start()
    {
        mesafe = OyuncuDokum.hedefMesafe;
    }
    void Update()
    {
        mesafe = OyuncuDokum.hedefMesafe;
    }
    private void OnMouseOver()
    {
        if(mesafe <= 2)
        {
            yaziGoster.GetComponent<Text>().text = "Silahý al.";
        }
    }
    private void OnMouseExit()
    {
        yaziGoster.GetComponent<Text>().text = "";
    }
}
