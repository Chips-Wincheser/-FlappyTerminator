using UnityEngine;

public class BirdFollower : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _xOffset;

    private float _speed = 2f;
    private Transform _transform;

    private void Awake()
    {
        _transform=transform;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(_player.transform.position.x + _xOffset, _transform.position.y, _transform.position.z);
        _transform.position=Vector3.Lerp(_transform.position, targetPosition, _speed*Time.deltaTime);
    }
}
