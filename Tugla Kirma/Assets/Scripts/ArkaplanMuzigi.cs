using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanMuzigi : MonoBehaviour
{
    static bool sahnedeMuzik;
    // Start is called before the first frame update
    void Start()
    {
        if(!sahnedeMuzik)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            sahnedeMuzik = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
