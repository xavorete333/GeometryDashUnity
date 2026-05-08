using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public void Continuar()
    {
        SceneManager.LoadScene("Menu");
    }
}