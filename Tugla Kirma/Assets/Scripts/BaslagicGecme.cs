using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaslagicGecme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DigerSahne()
    {
        Tugla.toplamTuglaSayisi = 0;
        GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuanSifirla();
        SceneManager.LoadScene("Bolum1");
    }
}
