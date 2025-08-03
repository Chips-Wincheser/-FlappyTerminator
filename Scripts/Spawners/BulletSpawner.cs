using UnityEngine;

public class BulletSpawner : SpawnerBase<Bullet>
{
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private Vector3 _offset;

    private Vector3 _startPoint=new Vector3(0,0,0);

    protected override void Spawn()
    {
        if(_enemySpawner.SpawnPoint!=_startPoint)
        {
            Bullet bullet = Pool.GetObject();
            bullet.transform.position = _enemySpawner.SpawnPoint+_offset;
            bullet.gameObject.SetActive(true);
        
            bullet.RotateBy(0,Vector2.left);
        }
    }
}
