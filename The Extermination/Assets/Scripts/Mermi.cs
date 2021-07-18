using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mermi : MonoBehaviour
{
    public static int cephane;
    public int icCephane;
    public GameObject cephaneGostergesi;
    
    public static int yedekCephane;
    public int icYedekCephane;
    public GameObject yedekCephaneGostergesi;

    void Start()
    {
        
    }

    void Update()
    {
        icCephane = cephane;
        icYedekCephane = yedekCephane;
        cephaneGostergesi.GetComponent<Text>().text = icCephane.ToString();
        yedekCephaneGostergesi.GetComponent<Text>().text = icYedekCephane.ToString();
    }
}
