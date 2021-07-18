using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cephane : MonoBehaviour
{
    public AudioSource ses;

    void Start()
    {
            
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        sesCal();
        if(Mermi.cephane == 0)
        {
            Mermi.cephane += 10;
        }
        else
        {
            Mermi.yedekCephane += 10;
        }
        this.gameObject.SetActive(false);
    }
    public void sesCal()
    {
        ses.Play();
    }
}
