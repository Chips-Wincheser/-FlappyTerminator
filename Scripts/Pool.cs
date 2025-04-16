using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private Queue<GameObject> _pool; 

    public IEnumerable<GameObject> PoolObjects=> _pool;

    private void Awake()
    {
        _pool = new Queue<GameObject>();
    }

    public GameObject GetObject()
    {
        if(_pool.Count == 0)
        {
            var poolObject = Instantiate(_prefab);

            return poolObject;
        }

        return _pool.Dequeue();
    }

    public void PutObject(GameObject poolObject)
    {
        _pool.Enqueue(poolObject);
        poolObject.gameObject.SetActive(false);
    }

    public void Reset()
    {
        _pool.Clear();
    }
}
