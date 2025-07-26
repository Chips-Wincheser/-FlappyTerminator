using System.Collections;
using UnityEngine;

abstract public class SpawnerBase<T> : MonoBehaviour where T : Component
{
    [SerializeField] protected float Delay;
    [SerializeField] protected Pool<T> Pool;

    private WaitForSeconds _waitForSeconds;
    protected Transform Transform;

    private void Awake()
    {
        _waitForSeconds=new WaitForSeconds(Delay);
        Transform=transform;
    }

    private void OnEnable()
    {
        StartCoroutine(Generate());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator Generate()
    {
        while (enabled)
        {
            yield return _waitForSeconds;
            Spawn();
        }
    }

    protected abstract void Spawn();
}
