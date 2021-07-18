using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    public GameObject balon;
    float olusturmaSure = 1f;
    float zamanSayaci = 0f;

    Kontrol kontrolScript;
    // Start is called before the first frame update
    void Start()
    {
        kontrolScript = this.gameObject.GetComponent<Kontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        int katsayi = (int)(kontrolScript.zamanSayaci / 10) - 6;
        katsayi *= -1;
        if(zamanSayaci < 0 && kontrolScript.zamanSayaci > 0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.16f,2.16f), -6f, 0), Quaternion.Euler(0, 0, 0));
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f*katsayi,80f*katsayi), 0));
            zamanSayaci = olusturmaSure;
        }
    }
}
