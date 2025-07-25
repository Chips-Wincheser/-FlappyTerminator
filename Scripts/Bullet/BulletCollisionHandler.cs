using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Bird>(out _) || collider.TryGetComponent<EnemyRemover>(out _))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out _))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
