using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 20.0f;
    public static int damage = 40;
    public Rigidbody rb;
    public GameObject impactEffect;
    Vector3 PipeMove;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position += transform.forward * speed * Time.deltaTime;
        //rb.AddForce(new Vector3(0, 0, speed), ForceMode.Impulse);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider hitInfo)
    {
        EnemyMovement enemy = hitInfo.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
