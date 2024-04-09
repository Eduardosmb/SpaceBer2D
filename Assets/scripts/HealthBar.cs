using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float healthMax = 14;
    public Image healthBar;

    private void OnEnable()
    {
        // Inscreve-se para o evento LifeChanged definido em outro script
        enemyCollision.LifeChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        // Desinscreve-se do evento quando este objeto for desativado
        enemyCollision.LifeChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float currentHealth)
    {
        // Atualiza a barra de vida com base no valor de vida fornecido
        float clampedHealth = Mathf.Clamp(currentHealth, 0, healthMax);
        healthBar.fillAmount = clampedHealth / healthMax;
    }
}
