using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericEnemyShoot : MonoBehaviour
{
        public GameObject projetil;
        public float speed = 5f;

        float timeToShoot = 0f;
        float timeNextShoot = 0f;

        void Start()
        {
            timeNextShoot = Random.Range(0f, 3f);
        }

        void Update()
        {
            timeToShoot += Time.deltaTime;
            if (timeToShoot > timeNextShoot)
            {
                Shoot();
            }

        }

        void Shoot()
        {
            Vector3 spawnPosition = transform.position;
            Quaternion spawnRotation = Quaternion.identity;
            GameObject newProjectile = Instantiate(projetil, spawnPosition, spawnRotation);

            Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.up * speed;

            timeToShoot = 0f;
            timeNextShoot = Random.Range(0f, 3f);
        }
}
