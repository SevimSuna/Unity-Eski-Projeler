using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarjor : MonoBehaviour
{
    public AudioSource ses;
    public GameObject vurma;
    public GameObject cross;
    public GameObject trigger;
    public int sarjor;
    public int ySarjor;
    public int yEkran;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sarjor = Mermi.cephane;
        ySarjor = Mermi.yedekCephane;

        if(ySarjor == 0)
        {
            yEkran = 0;
        }
        else
        {
            yEkran = 10 - sarjor;
        }
        if(sarjor <= 0)
        {
            trigger.GetComponent<Shooting>().enabled = false;
            vurma.GetComponent<Mermi>().enabled = false;
            this.GetComponent<Animation_>().enabled = false;
        }
        else
        {
            trigger.GetComponent<Shooting>().enabled = true;
            vurma.GetComponent<Mermi>().enabled = true;
            this.GetComponent<Animation_>().enabled = true;
        }
        if(Input.GetButtonDown("Sarjor"))
        {
            if(yEkran >= 1)
            {
                if(ySarjor <= yEkran)
                {
                    Mermi.cephane += ySarjor;
                    Mermi.yedekCephane -= ySarjor;
                }
                else
                {
                    Mermi.cephane += yEkran;
                    Mermi.yedekCephane -= yEkran;
                    StartCoroutine(ActionReload());
                }
            }
            StartCoroutine(EnableScripts());
        }
    }
    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.1f);
        this.GetComponent<Animation_>().enabled = true;
        cross.SetActive(true);
        trigger.SetActive(true);
    }
    IEnumerator ActionReload()
    {
        yield return new WaitForSeconds(0.1f);
        this.GetComponent<Animation_>().enabled = false;
        cross.SetActive(false);
        trigger.SetActive(false);
        ses.Play();
        GetComponent<Animation>().Play("Rotate");
    }
}
