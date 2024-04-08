using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float speed = 5f;

    public GameObject tiro;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
    }
    void Shoot()
        {
            Vector3 spawnPosition = transform.position;
            Quaternion spawnRotation = Quaternion.identity;
            GameObject newProjectile = Instantiate(tiro, spawnPosition, spawnRotation);

            Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * speed;

        }
}
