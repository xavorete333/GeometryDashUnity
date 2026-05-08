using UnityEngine;

public class TopC : MonoBehaviour
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