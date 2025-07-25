using System.Collections;
using UnityEngine;

abstract public class SpawnerBase : MonoBehaviour
{
    [SerializeField] protected float _delay;
    [SerializeField] protected Pool _pool;

    private WaitForSeconds _waitForSeconds;
    protected Transform _transform;

    private void Awake()
    {
        _waitForSeconds=new WaitForSeconds(_delay);
        _transform=transform;
    }

    private void OnEnable()
    {
        StartCoroutine(GanerateEnemy());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator GanerateEnemy()
    {
        while (enabled)
        {
            yield return _waitForSeconds;
            Spawn();
        }
    }

    protected abstract void Spawn();
}
