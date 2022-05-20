using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    bool attacked = false;
    float timer = 0;
    public Transform firePoint;
    public GameObject PipePrefab;

    // Update is called once per frame
    void Update()
    {
        if (attacked == true)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 0.5f)
        {
            attacked = false;
            timer = 0;
        }
        if (Input.GetButtonDown("Fire1") && attacked == false)
        {
            Shoot();
            attacked = true;
        }
    }

    void Shoot()
    {
        Instantiate(PipePrefab, firePoint.position, firePoint.rotation);
    }

}
