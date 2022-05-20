using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    int playerhealth = 3;
    public int movespeed = 2;
    public int JumpForce = 2;
    Vector3 movement;
    public Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }   

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.LeftShift) == false)
        {
            transform.Translate(movement * Time.deltaTime * movespeed);
        }
        
        if (Input.GetKey(KeyCode.LeftShift) == true)
        {
            transform.Translate(movement * Time.deltaTime * movespeed * 2);
        }
        if (Input.GetButtonDown("Jump"))// && Mathf.Abs(_rigidbody.velocity.y) >= 0.01f)
        {
            _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerhealth = playerhealth - 1;
        }

    }
    void playershealth()
    {
        if (playerhealth == 0)
        {
            Die();
        }
    }
    void Die()
    {
        UnityEditor.EditorApplication.ExitPlaymode();
    }

}
