using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{
    public bool oyunAktif = true;
    public int goldNumber = 0;
    public Text goldCount;
    public Button baslaButonu;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoldInc()
    {
        goldNumber++;
        goldCount.text = "" + goldNumber; 
    }
    public void OyunaBasla()
    {
        oyunAktif = true;
        baslaButonu.gameObject.SetActive(false);
    }
}
