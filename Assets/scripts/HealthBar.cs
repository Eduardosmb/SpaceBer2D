using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float healthMax = 14;
    public Image healthBar;

    void Start()
    {
       gameObject.SetActive(false); 
    }
    private void OnEnable()
    {
        enemyCollision.LifeChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        enemyCollision.LifeChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float currentHealth)
    {
        float clampedHealth = Mathf.Clamp(currentHealth, 0, healthMax);
        healthBar.fillAmount = clampedHealth / healthMax;
    }
}
