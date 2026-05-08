using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    public float fallSpeed = 5f;
    public float destroyY = -10f;

    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        // destruir si se sale
        if (transform.position.y < destroyY)
        {
            Destroy(gameObject);
        }
    }
}