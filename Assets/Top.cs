using UnityEngine;
using TMPro;

public class Top : MonoBehaviour
{
    public TextMeshProUGUI text;

    void OnEnable()
    {
        MostrarTop();
    }

    void MostrarTop()
    {
        text.text = "🏆 TOP 5\n\n";

        for (int i = 0; i < 5; i++)
        {
            if (PlayerPrefs.HasKey("Score" + i))
            {
                string name = PlayerPrefs.GetString("Name" + i);
                float score = PlayerPrefs.GetFloat("Score" + i);

                text.text += (i + 1) + ". " + name + " - " + score.ToString("F0") + "\n";
            }
            else
            {
                text.text += (i + 1) + ". ---\n";
            }
        }
    }
}