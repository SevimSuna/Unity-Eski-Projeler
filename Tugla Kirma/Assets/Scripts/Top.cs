using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    private GameObject pedal;
    private bool oyunBasladi = false;

    public static int toplamTuglaSayisi;
    // Start is called before the first frame update
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
        toplamTuglaSayisi++;
    }

    // Update is called once per frame
    void Update()
    {
        if(!oyunBasladi)
        {
            toplamTuglaSayisi--;
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0) && !oyunBasladi)
        {
            oyunBasladi = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 8f);
        }
    }
}
