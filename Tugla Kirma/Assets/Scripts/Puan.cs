using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    private int puan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PuanArttir()
    {
        puan++;
    }
    public int PuaniAl()
    {
        return puan;
    }
    public void PuanSifirla()
    {
        puan = 0;
    }
}
