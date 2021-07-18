using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patlatma : MonoBehaviour
{
    public GameObject patlama;

    Kontrol kontrolScript;

    private void Start()
    {
        kontrolScript = GameObject.Find("_Scripts").GetComponent<Kontrol>(); 
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation); 
        Destroy(this.gameObject);
        Destroy(go, 0.433f);
        kontrolScript.BalonEkle();
    }
}
