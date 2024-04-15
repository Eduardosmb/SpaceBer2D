using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ReturnToStart()
    {
        SceneManager.LoadScene("Jogo");
    }
}
