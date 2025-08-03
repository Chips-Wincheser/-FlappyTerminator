using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out _))
        {
            Destroy(collision.gameObject);
        }
    }
}
