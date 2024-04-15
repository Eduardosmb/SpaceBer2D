using UnityEngine;

public class spawnInimigo : MonoBehaviour
{
    public GameObject characterPrefab;
    public float spawnInterval = 5f;
    public Vector2 spawnAreaSize;
    private float timer = 0f;
    public static bool canSpawn = true;

    public static void EnableSpawning()
    {
        canSpawn = true;
    }

    void OnEnable()
    {
        Score.OnScoreThresholdReached += DisableSpawning;
    }

    void OnDisable()
    {
        Score.OnScoreThresholdReached -= DisableSpawning;
    }

    void Update()
    {
        if (!canSpawn) return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            Spawn();
            timer = 0f;
        }
    }

    void Spawn()
    {
        Vector2 spawnPosition = new Vector2(
            transform.position.x + Random.Range(-spawnAreaSize.x / 2f, spawnAreaSize.x / 2f),
            transform.position.y + Random.Range(-spawnAreaSize.y / 2f, spawnAreaSize.y / 2f)
        );

        Instantiate(characterPrefab, spawnPosition, Quaternion.identity);
    }

    void DisableSpawning()
    {
        canSpawn = false;
    }
}
