// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class spawnBoos : MonoBehaviour
// {
//     public GameObject BossPrefab;        
//     private float timer = 0f;

//     void Update()
//     {
//         timer += Time.deltaTime;

//         if (timer >= spawnInterval)
//         {
//             Spawn();
// =    }

//     void Spawn()
//     {
//         Vector2 spawnPosition = new Vector2(
//             transform.position.x + Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f),
//             transform.position.y + Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f)
//         );

//         Instantiate(characterPrefab, spawnPosition, Quaternion.identity);
//     }

//     private void OnDrawGizmosSelected()
//     {
//         Gizmos.color = Color.green;
//         Gizmos.DrawWireCube(transform.position, new Vector3(spawnAreaSize.x, spawnAreaSize.y, 0f));
//     }
// }
