using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundandRepeat : MonoBehaviour
{
    public AudioClip lifeSound;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Basket")
        {
            Destroy(collision.gameObject);
        }
        
    }

}
