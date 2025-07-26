using UnityEngine;

public class EnemySpawner : SpawnerBase<Enemy>
{
    [SerializeField] private float _lowerBound;
    [SerializeField] private float _upperBound;

    protected override void Spawn()
    {
        float spawnPositionY = Random.Range(_upperBound, _lowerBound);
        Vector3 spawnPoint = new Vector3(Transform.position.x, spawnPositionY, Transform.position.z);

        var enemy = Pool.GetObject();
        enemy.transform.position = spawnPoint;
        enemy.gameObject.SetActive(true);
    }
}
