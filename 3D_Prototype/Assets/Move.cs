using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
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
        transform.Translate(movement * Time.deltaTime * movespeed);
        movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        if (Input.GetButtonDown("Jump"))// && Mathf.Abs(_rigidbody.velocity.y) >= 0.01f)
        {
            _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }
    }
}
