using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetilDel : MonoBehaviour
{
    public float timeToDisappear = 3f; // Tempo para o projetil desaparecer
    private float elapsedTime = 0f; // Tempo decorrido desde que o projetil foi instanciado

    void Update()
    {
        // elapsedTime += Time.deltaTime;

        // if (elapsedTime >= timeToDisappear)
        // {
        //     Destroy(gameObject);
        // }
    }
}
