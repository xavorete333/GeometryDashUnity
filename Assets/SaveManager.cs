using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject savePanel;
    public InputField nameInput;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip saveSound;

    public void ConfirmSave()
    {
        string playerName = nameInput.text;

        if (playerName == "")
        {
            Debug.Log("Nombre vacío ❌");
            return;
        }

        // 🔥 GUARDAR (ejemplo simple con PlayerPrefs)
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        Debug.Log("Guardado: " + playerName);

        // 🔊 SONIDO
        if (audioSource != null && saveSound != null)
        {
            audioSource.PlayOneShot(saveSound);
        }

        // ❌ CERRAR PANEL
        savePanel.SetActive(false);

        // 🧹 LIMPIAR INPUT
        nameInput.text = "";
    }

    public void ClosePanel()
    {
        savePanel.SetActive(false);
    }
}