using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMover : MonoBehaviour
{
    [SerializeField] private float _tapForce;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    [SerializeField] private float _maxRotationZ;
    [SerializeField] private float _minRotationZ;

    [SerializeField] private PlayerInput _playerInput;

    private Vector3 _startPosition;
    
    private Rigidbody2D _rigidbody2D;
    
    private Quaternion _maxRotation;
    private Quaternion _minRotation;
    
    private Transform _transform;

    private bool _isJump=false;

    private void Awake()
    {
        _transform=transform;
        _startPosition = _transform.position;
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);

    }

    private void OnEnable()
    {
        _playerInput.Jumping+=Jump;
    }

    private void OnDisable()
    {
        _playerInput.Jumping-=Jump;
    }

    private void FixedUpdate()
    {
        if(_isJump)
        {
            _rigidbody2D.velocity = new Vector2(_speed, _tapForce);
            _transform.rotation = _maxRotation;
            _isJump=false;
        }

        _transform.rotation=Quaternion.Lerp(_transform.rotation, _minRotation, _rotationSpeed*Time.deltaTime);
    }

    private void Jump()
    {
        _isJump=true;
    }
}
