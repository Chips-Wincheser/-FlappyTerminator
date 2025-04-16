using UnityEngine;

public class EnemySpawner : SpawnerBase
{
    [SerializeField] private float _lowerBound;
    [SerializeField] private float _upperBound;

    protected override void Spawn()
    {
        float spawnPositionY = Random.Range(_upperBound, _lowerBound);
        Vector3 spawnPoint = new Vector3(_transform.position.x, spawnPositionY, _transform.position.z);

        var enemy = _pool.GetObject();
        enemy.transform.position = spawnPoint;
        enemy.gameObject.SetActive(true);
    }
}
