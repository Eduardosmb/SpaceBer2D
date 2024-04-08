using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetilDel : MonoBehaviour
{
    public float timeToDisappear = 3f;
    private float elapsedTime = 0f; 

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= timeToDisappear)
        {
            Destroy(gameObject);
        }
    }
}
