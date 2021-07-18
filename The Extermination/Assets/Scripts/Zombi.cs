using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi : MonoBehaviour
{
    public GameObject karakter, rakip;
    public float hedefUzakligi, islemUzakligi = 10, rakipHiz;
    public int saldiriTetikleyici;
    public RaycastHit atis;
    public AudioSource ses;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(karakter.transform);
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out atis))
        {
            hedefUzakligi = atis.distance;
            if(hedefUzakligi < islemUzakligi)
            {
                rakipHiz = 0.1f;
                if(saldiriTetikleyici == 0)
                {
                    rakip.GetComponent<Animation>().Play("Walking");
                    ses.Play();
                    transform.position = Vector3.MoveTowards(transform.position, karakter.transform.position, rakipHiz);
                }
            }
            else
            {
                rakipHiz = 0;
                rakip.GetComponent<Animation>().Play("Idle");
            }
        }
        if(saldiriTetikleyici == 1)
        {
            rakipHiz = 0;
            rakip.GetComponent<Animation>().Play("Attacking");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        saldiriTetikleyici = 1;
    }
    private void OnTriggerExit(Collider other)
    {
        saldiriTetikleyici = 0;
    }
}
