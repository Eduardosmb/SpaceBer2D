using System;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public static event Action OnBossDefeated;

    // Método para ser chamado quando a vida do boss chegar a 0
    public void DefeatBoss()
    {
        OnBossDefeated?.Invoke();
    }
}
