using UnityEngine;

public class EnemySpawner : SpawnerBase<Enemy>
{
    [SerializeField] private float _lowerBound;
    [SerializeField] private float _upperBound;

    public Vector3 SpawnPoint {get;private set;}

    protected override void Spawn()
    {
        float spawnPositionY = Random.Range(_upperBound, _lowerBound);
        SpawnPoint = new Vector3(Transform.position.x, spawnPositionY, Transform.position.z);

        Enemy enemy = Pool.GetObject();
        enemy.transform.position = SpawnPoint;
        enemy.gameObject.SetActive(true);
    }
}
