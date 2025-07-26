using UnityEngine;

public class EnemyRemover : MonoBehaviour
{
    [SerializeField] private Pool<Enemy> _enemyPool;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            _enemyPool.PutObject(enemy);
        }
    }
}
