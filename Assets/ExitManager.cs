using UnityEngine;
using TMPro;

public class ExitManager : MonoBehaviour
{
    public GameObject panel;
    public TMP_InputField inputNombre;
    public GameObject botonConfirmar;

    private bool guardar = false;

    // Abrir panel
    public void MostrarPanel()
    {
        panel.SetActive(true);
    }

    // BOTÓN SI
    public void OpcionSi()
    {
        guardar = true;

        inputNombre.gameObject.SetActive(true);
        botonConfirmar.SetActive(true);
    }

    // BOTÓN NO
    public void OpcionNo()
    {
        guardar = false;
        SalirJuego();
    }

    // BOTÓN CANCELAR
    public void Cancelar()
    {
        panel.SetActive(false);

        inputNombre.gameObject.SetActive(false);
        botonConfirmar.SetActive(false);
    }

    // BOTÓN CONFIRMAR
    public void ConfirmarNombre()
    {
        if (guardar)
        {
            string nombre = inputNombre.text;

            if (nombre != "")
            {
                GuardarScore(nombre);
            }
        }

        SalirJuego();
    }

    void GuardarScore(string nombre)
    {
        float score = PlayerPrefs.GetFloat("LastScore", 0);

        for (int i = 0; i < 5; i++)
        {
            if (!PlayerPrefs.HasKey("Score" + i) || score > PlayerPrefs.GetFloat("Score" + i))
            {
                for (int j = 4; j > i; j--)
                {
                    PlayerPrefs.SetFloat("Score" + j, PlayerPrefs.GetFloat("Score" + (j - 1), 0));
                    PlayerPrefs.SetString("Name" + j, PlayerPrefs.GetString("Name" + (j - 1), ""));
                }

                PlayerPrefs.SetFloat("Score" + i, score);
                PlayerPrefs.SetString("Name" + i, nombre);
                break;
            }
        }

        PlayerPrefs.Save();
    }

    void SalirJuego()
    {
        Application.Quit();
    }
}