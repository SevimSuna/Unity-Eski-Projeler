using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public Text puan;
    // Start is called before the first frame update
    void Start()
    {
        puan.text = "Puanýnýz: " + GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuaniAl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnaSahneyeGec()
    {
        Tugla.toplamTuglaSayisi = 0;
        GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuanSifirla();
        SceneManager.LoadScene(1);
    }
}
