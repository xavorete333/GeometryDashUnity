using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelProgressBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI progressText;
    public static float currentProgress;

    public Transform player;
    public Transform endPoint;

    private float startX;
    private float endX;

    void Start()
    {
        startX = player.position.x;
        endX = endPoint.position.x;
    }

    void Update()
    {

        float progress = (player.position.x - startX) / (endX - startX);
        progress = Mathf.Clamp01(progress);
        currentProgress = progress;

        float percent = progress * 100f;

        slider.value = percent;
        progressText.text = Mathf.RoundToInt(percent) + "%";
    }
}