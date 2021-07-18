using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    private float hiz = 5f;

    public OyunKontrol oyunK;
    public AudioClip gold, fall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunK.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
        


    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("Enemy"))
        {
            GetComponent<AudioSource>().PlayOneShot(fall, 1f);
            oyunK.oyunAktif = false;
        }
        else if (c.gameObject.tag.Equals("Gold"))
        {
            GetComponent<AudioSource>().PlayOneShot(gold,1f);
            oyunK.GoldInc();
            Destroy(c.gameObject);
        }
    }
}
