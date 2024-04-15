using UnityEngine;
using UnityEngine.Events;

public class spawnBoss : MonoBehaviour
{
    public GameObject BossPrefab;
    public Camera mainCamera;

    private void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        Score.OnScoreThresholdReached += SpawnBoss;
        Boss.OnBossDefeated += HandleBossDefeat;
    }

    private void OnDisable()
    {
        Score.OnScoreThresholdReached -= SpawnBoss;
        Boss.OnBossDefeated -= HandleBossDefeat;
    }

    private void SpawnBoss()
    {
        Debug.Log("Spawning boss.");
        Vector3 spawnPosition = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10f));
        Instantiate(BossPrefab, spawnPosition, Quaternion.identity);
    }

    private void HandleBossDefeat()
    {
        spawnInimigo.EnableSpawning();
    }
}
