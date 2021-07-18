using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kontrol : MonoBehaviour
{
    public float zamanSayaci = 60f;
    int balonSayaci = 0;

    public Text zaman, balon;
    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        balon.text = "Balon: " + balonSayaci;
    }

    // Update is called once per frame
    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = "Zaman: " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i=0; i<go.Length; i++)
            {
                GameObject go1 = Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
                Destroy(go1, 0.433f);
            }
        }
    }
    public void BalonEkle()
    {
        balonSayaci += 1;
        balon.text = "Balon: " + balonSayaci;
    }
}
