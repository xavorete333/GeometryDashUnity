using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class ScoreEntry
{
    public string name;
    public float score;
}

public class TopSystem : MonoBehaviour
{
    public static List<ScoreEntry> topList = new List<ScoreEntry>();

    public static void AddScore(string name, float score)
    {
        ScoreEntry newEntry = new ScoreEntry();
        newEntry.name = name;
        newEntry.score = score;

        topList.Add(newEntry);

        // ordenar
        topList.Sort((a, b) => b.score.CompareTo(a.score));

        // dejar solo 5
        if (topList.Count > 5)
            topList.RemoveAt(5);
    }
}