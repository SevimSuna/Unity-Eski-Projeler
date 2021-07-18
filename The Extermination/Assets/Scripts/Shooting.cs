using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int damage = 5;
    public float targetDistance;
    public float getDistance = 15f;

    Enemy shootEnemy;
    void Start()
    {
        shootEnemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
    }
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {

                targetDistance = hit.distance;
                if(targetDistance<getDistance)
                {
                    if(hit.transform.tag == "Enemy")
                    {
                        shootEnemy.EnemyFunc(damage); 
                    }
                }
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal, Color.green, 2, false);
    }
}
