using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class altDuvar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.name.Equals("top"))
        {
            SceneManager.LoadScene("OyunuKaybettiniz"); 
        }
    }

}
