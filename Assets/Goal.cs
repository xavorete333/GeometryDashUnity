using UnityEngine;

public class Goal : MonoBehaviour
{
    public WinManager winManager;

    private bool activated = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (activated) return;

        if (other.CompareTag("Player"))
        {
            activated = true;
            winManager.Win();
        }
    }
}