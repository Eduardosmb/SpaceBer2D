using UnityEngine;
using UnityEngine.Events;

public class enemyCollision : MonoBehaviour
{
    public static event UnityAction<float> LifeChanged;
    public int life = 20;

    void Start(){
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (life <= 0)
        {
            FindObjectOfType<Score>().AddScore(100); // Adicionar 100 pontos
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("playerShoot"))
        {
            life -= 1;
            LifeChanged?.Invoke(life);
        }
    }
}
