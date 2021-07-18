using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SilahAl : MonoBehaviour
{
    public float mesafe = OyuncuDokum.hedefMesafe;
    public GameObject yaziGoster;
    public GameObject yerdekiSilah;
    public GameObject gercekSilah;
    public GameObject cephaneGoster;
    public GameObject cross;
    public AudioSource almaSes;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Pick"))
        {
            if(mesafe <= 2)
            {
                SilahKazan();
            }
        }
    }
    private void OnMouseOver()
    {
        Debug.Log(mesafe.ToString());
        if (mesafe <= 2)
        {
            yaziGoster.GetComponent<Text>().text = "9mm";
            
        }
    }
    private void OnMouseExit()
    {
        yaziGoster.GetComponent<Text>().text = "";
    }
    public void SilahKazan()
    {
        almaSes.Play();
        transform.position = new Vector3(0, -100, 0);
        yerdekiSilah.SetActive(false);
        gercekSilah.SetActive(true);
        cephaneGoster.SetActive(true);
        cross.SetActive(true);
    }
}
