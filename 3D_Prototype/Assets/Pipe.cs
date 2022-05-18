using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 20.0f;
    public int damage = 40;
    public Rigidbody rb;
    public GameObject impactEffect;
    Vector3 PipeMove;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(0, speed, 0), ForceMode.Impulse);
    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyMovement enemy = hitInfo.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        //Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }

}
