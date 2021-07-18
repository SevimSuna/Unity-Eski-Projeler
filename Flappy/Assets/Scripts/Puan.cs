using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    public int value;
    public Text point;
    public int rawPoint = 5;
    public Text result;
    void Start()
    {
        rawPoint = 5;
    }

    // Update is called once per frame
    void Update()
    {
        point.text = "PUAN: "+value.ToString("f0");
    }
    public void Buton1()
    {
        if(result.text == "Doðru")
        {
            value += 5;
        }
        
    }
    public void Buton2()
    {
        if(result.text == "Doðru")
        {
            value += 5;
        }
        
    }
}
