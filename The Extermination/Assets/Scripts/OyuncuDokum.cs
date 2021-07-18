using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuDokum : MonoBehaviour
{
    public static float hedefMesafe;
    public float hedefe;
    void Start()
    {
        
    }
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            hedefe = hit.distance;
            hedefMesafe = hedefe;
        }
    }
}
