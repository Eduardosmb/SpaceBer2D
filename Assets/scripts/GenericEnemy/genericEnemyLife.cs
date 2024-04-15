using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericEnemyLife : MonoBehaviour
{
    public int life = 1;

    void Update()
    {
        if (life <= 0)
        {
            FindObjectOfType<Score>().AddScore(40); // Adicionar 40 pontos
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("playerShoot"))
        {
            life -= 1;
        }
    }
}