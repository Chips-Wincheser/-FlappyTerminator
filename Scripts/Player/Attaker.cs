using UnityEngine;

public class Attaker : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private Vector3 _offset;

    private Bullet _bullet;
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
        _bullet = Instantiate(_bulletPrefab, _transform.position+_offset, Quaternion.identity);

        _bullet.SetDirection(Vector3.right);
    }
}
