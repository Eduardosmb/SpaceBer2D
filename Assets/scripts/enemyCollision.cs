using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{

    public int life = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0){
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("playerShoot")){
            life -= 1;
            Debug.Log("deu dano");
                    
        }
    }
}
