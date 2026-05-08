using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    public string nombreEscena;

    void Update()
    {
        // Si presionas espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(nombreEscena);
        }
    }
}