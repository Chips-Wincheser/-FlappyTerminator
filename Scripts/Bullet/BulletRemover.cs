using UnityEngine;

public class BulletRemover : MonoBehaviour
{
    [SerializeField] private Pool<Bullet> _bulletPool;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Bullet>(out Bullet bullet))
        {
            _bulletPool.PutObject(bullet);
        }
    }
}
