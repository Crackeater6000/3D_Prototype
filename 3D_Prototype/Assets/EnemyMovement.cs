using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform target;
    float speed = .025f;
    public static int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowObject();
    }


    void FollowObject()
    {
        //Video where I found how to make an object follow another object https://www.youtube.com/watch?v=jq_TXQ8BGek

        transform.LookAt(target.position);
        transform.Translate(0.0f, 0.0f, speed);


    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
} 
