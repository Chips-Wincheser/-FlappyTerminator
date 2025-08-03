using System.Collections.Generic;
using UnityEngine;

public class Pool<T> : MonoBehaviour where T : Component
{
    [SerializeField] private T _prefab;

    private Queue<T> _pool; 

    private void Awake()
    {
        _pool = new Queue<T>();
    }

    public T GetObject()
    {
        if (_pool.Count == 0)
        {
            var poolObject = Instantiate(_prefab);

            return poolObject;
        }

        return _pool.Dequeue();
    }

    public void PutObject(T poolObject)
    {
        _pool.Enqueue(poolObject);
        poolObject.gameObject.SetActive(false);
    }

    public void Reset()
    {
        _pool.Clear();
    }
}
