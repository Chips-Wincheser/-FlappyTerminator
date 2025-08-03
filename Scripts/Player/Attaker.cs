using UnityEngine;

public class Attaker : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private BulletPool _bulletPool;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void OnEnable()
    {
        _playerInput.Attaking+=StartAttack;
    }

    private void OnDisable()
    {
        _playerInput.Attaking-=StartAttack;
    }

    private void StartAttack()
    {
        //_bullet = Instantiate(_bulletPrefab, _transform.position+_offset, Quaternion.identity);
        Bullet bullet = _bulletPool.GetObject();
        bullet.transform.position = transform.position+_offset;
        bullet.gameObject.SetActive(true);

        bullet.RotateBy(0,Vector3.left);
    }
}
