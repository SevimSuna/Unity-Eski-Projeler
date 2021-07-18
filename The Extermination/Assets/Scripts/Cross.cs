using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;
    public GameObject right;
    public GameObject left;


    public float waitForSeconds = 5f;

    void Start()
    {
        top.GetComponent<Animator>().enabled = false;
        bottom.GetComponent<Animator>().enabled = false;
        right.GetComponent<Animator>().enabled = false;
        left.GetComponent<Animator>().enabled = false;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            top.GetComponent<Animator>().enabled = true;
            bottom.GetComponent<Animator>().enabled = true;
            right.GetComponent<Animator>().enabled = true;
            left.GetComponent<Animator>().enabled = true;
            StartCoroutine(Bekleme());
        }
    }
    IEnumerator Bekleme()   
    {
        yield return new WaitForSeconds(0.167f);
        top.GetComponent<Animator>().enabled = false;
        bottom.GetComponent<Animator>().enabled = false;
        right.GetComponent<Animator>().enabled = false;
        left.GetComponent<Animator>().enabled = false;
    }
}
