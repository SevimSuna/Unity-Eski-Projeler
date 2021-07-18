using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 10;
    void Start()
    {
        
    }
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);    
        }
    }
    public void EnemyFunc(int damage)
    {
        enemyHealth -= damage;
    }
}
