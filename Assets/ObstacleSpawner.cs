using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject spikePrefab;
    public GameObject blockPrefab;

    public Transform player;
    public AudioSource music;

    public float spawnDistance = 15f;
    public float lastSpawnX = 0f;

    void Update()
    {
        float musicTime = music.time;

        // Generación basada en tiempo (ritmo)
        if (player.position.x > lastSpawnX - spawnDistance)
        {
            SpawnPattern();
            lastSpawnX += 3f;
        }
    }

    void SpawnPattern()
    {
        float random = Random.value;

        // PATRONES DIFÍCILES 🔥
        if (random < 0.3f)
        {
            // Triple spike
            SpawnSpike(0);
            SpawnSpike(1);
            SpawnSpike(2);
            SpawnSpike(3);
            spawnDistance += 2f; // Aumenta la distancia para el próximo spawn
            SpawnSpike(4);
            SpawnSpike(5);
            SpawnSpike(6);
        }
        else if (random < 0.6f)
        {
            // Bloque + spike arriba
            SpawnBlock(0);
            SpawnSpike(1.5f);
            SpawnSpike(3f);
            SpawnSpike(4.5f);
            SpawnSpike(6f);
            SpawnSpike(7.5f);
        }
        else
        {
            // Spike + espacio + spike
            SpawnSpike(0);
            SpawnSpike(3);
            SpawnSpike(6);
            SpawnSpike(7);
            SpawnSpike(8);
            SpawnSpike(9);

        }
        if (music.time > 2f && music.time < 2.1f)
        {
            SpawnSpike(0);
        }
    }

    void SpawnSpike(float offset)
    {
        Vector3 pos = new Vector3(player.position.x + spawnDistance + offset, 0, 0);
        Instantiate(spikePrefab, pos, Quaternion.identity);
    }

    void SpawnBlock(float offset)
    {
        Vector3 pos = new Vector3(player.position.x + spawnDistance + offset, 1, 0);
        Instantiate(blockPrefab, pos, Quaternion.identity);
    }
}