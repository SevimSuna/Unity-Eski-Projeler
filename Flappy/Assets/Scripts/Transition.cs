using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject field;
    public bool temas;
    void Start()
    {
        temas = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(temas == true)
        {
            Invoke("IleriAta", 3f);
            temas = false;
        }
    }
    void IleriAta()
    {
        transform.position = transform.position + new Vector3(13.93f, 0, 0);
    }
}
