using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject panel;

    public void Abrir()
    {
        panel.SetActive(true);
    }

    public void Cerrar()
    {
        panel.SetActive(false);
    }
}