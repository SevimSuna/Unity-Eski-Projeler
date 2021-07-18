using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed;
    public float jumpPower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if(Input.GetMouseButtonDown(1))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
        }
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "gecis")
        {
            Destroy(c.gameObject);
            c.gameObject.transform.parent.root.gameObject.GetComponent<Transition>().temas = true;
        }
    }
}
