using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public AudioSource music; // 🎵 referencia a la música

    private bool isPaused = false;

    public void TogglePause()
    {
        if (isPaused)
            Resume();
        else
            Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;

        if (music != null)
            music.Pause(); // ⏸ pausa música

        pausePanel.SetActive(true);
        isPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;

        if (music != null)
            music.UnPause(); // ▶ reanuda música

        pausePanel.SetActive(false);
        isPaused = false;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;

        if (music != null)
            music.Stop(); // 🔇 opcional al salir

        SceneManager.LoadScene("Menu");
    }
}