using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    GameObject bullet;
    public Transform rotationBullet;
    public Transform firePoint;
    public float bulletForce = 3f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        bullet = Instantiate(bulletPrefab, firePoint.position, rotationBullet.rotation);
        Quaternion additionalRotation = Quaternion.Euler(0f, 0f, 90f);
        bullet.transform.rotation *= additionalRotation;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.transform.Rotate(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10), 0);
        rb.AddForce(firePoint.up * 15, ForceMode2D.Impulse);


    }
}
