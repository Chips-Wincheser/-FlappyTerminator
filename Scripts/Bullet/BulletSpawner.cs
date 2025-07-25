using UnityEngine;

public class BulletSpawner : SpawnerBase
{
    protected override void Spawn()
    {
        GameObject bullet = _pool.GetObject();
        bullet.transform.position = _transform.position;
        bullet.gameObject.SetActive(true);

        if (bullet.TryGetComponent<Bullet>(out var bulletComponent))
        {
            bulletComponent.SetDirection(Vector2.left);
        }
    }
}
