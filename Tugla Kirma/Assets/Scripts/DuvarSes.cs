using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarSes : MonoBehaviour
{
    public AudioClip sesEfect;
    public GameObject carpma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        AudioSource.PlayClipAtPoint(sesEfect, new Vector3(transform.position.x, transform.position.y, transform.position.z - 15));
        Vector3 pos = c.contacts[0].point;
        GameObject go = Instantiate(carpma, pos, Quaternion.identity) as GameObject;
        Destroy(go, 1f);
    }
}
