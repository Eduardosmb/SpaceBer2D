using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    public GameObject shoot;
    public int life = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (life <= 0){
            SceneManager.LoadScene("Fim");
        }
    }

    private void OnTriggerEnter(Collider other){

        if (other.gameObject.CompareTag("shoot") || other.gameObject.CompareTag("enemy")){
            life -= 1;
            Debug.Log("Life: " + life);
        }
    }
}
