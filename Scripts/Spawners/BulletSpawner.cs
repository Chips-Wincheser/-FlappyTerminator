using UnityEngine;

public class BulletSpawner : SpawnerBase<Bullet>
{
    protected override void Spawn()
    {
        Bullet bullet = Pool.GetObject();
        bullet.transform.position = Transform.position;
        bullet.gameObject.SetActive(true);

        if (bullet.TryGetComponent<Bullet>(out var bulletComponent))
        {
            bulletComponent.SetDirection(Vector2.left);
        }
    }
}
