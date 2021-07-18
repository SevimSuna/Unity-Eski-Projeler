using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public Sprite[] tuglaSprite;
    
    private int maxCarpmaSayisi;
    private int carpmaSayisi;
    private Puan puanScripti;

    public static int toplamTuglaSayisi;

    public AudioClip tuglaCarpmaSes;
    public AudioClip tuglaKirilmaSes;
    public GameObject kirilmaEfekt;
    // Start is called before the first frame update
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length + 1;
        toplamTuglaSayisi++;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.name.Equals("top"))
        {
            puanScripti.PuanArttir();
            carpmaSayisi++;
            if(carpmaSayisi >= maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;
                Debug.Log(toplamTuglaSayisi); 
                if(toplamTuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().birSonrakiSahne();
                }
                Vector3 pos = c.contacts[0].point;
                GameObject go = Instantiate(kirilmaEfekt, pos, Quaternion.identity) as GameObject;
                Color tuglaRengi = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = tuglaRengi;
                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(tuglaKirilmaSes, new Vector3(transform.position.x, transform.position.y, transform.position.z - 15));
                Destroy(this.gameObject);
            }
            else
            {
                AudioSource.PlayClipAtPoint(tuglaCarpmaSes, new Vector3(transform.position.x,transform.position.y,transform.position.z-15));
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpmaSayisi - 1];
            }
        }
    }
}
