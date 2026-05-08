using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenFlash : MonoBehaviour
{
    public Image flashImage;
    public float flashDuration = 0.5f;

    public void Flash()
    {
        if (flashImage == null)
        {
            Debug.LogError("FlashImage no asignado");
            return;
        }

        StartCoroutine(FlashRoutine());
    }

    IEnumerator FlashRoutine()
    {
        float timer = 0f;

        // 🔥 Fade IN
        while (timer < flashDuration / 2)
        {
            timer += Time.unscaledDeltaTime;
            float alpha = Mathf.Lerp(0, 1, timer / (flashDuration / 2));
            flashImage.color = new Color(1, 1, 1, alpha);
            yield return null;
        }

        timer = 0f;

        // 🔥 Fade OUT
        while (timer < flashDuration / 2)
        {
            timer += Time.unscaledDeltaTime;
            float alpha = Mathf.Lerp(1, 0, timer / (flashDuration / 2));
            flashImage.color = new Color(1, 1, 1, alpha);
            yield return null;
        }

        flashImage.color = new Color(1, 1, 1, 0);
    }
}