using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_ : MonoBehaviour
{
    AudioSource silahSesi;
    Animation silahAtesleme;
    Cephane bosSes;
    
    void Start()
    {
        silahSesi = GetComponent<AudioSource>();
        silahAtesleme = GetComponent<Animation>();
        bosSes = GameObject.FindGameObjectWithTag("Cephane").GetComponent<Cephane>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            silahAtesleme.Play("Gun");
            Mermi.cephane--;
            silahSesi.Play();
        }
    }
}
