using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Vector2 _direction;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void RotateBy(float deltaDegrees, Vector2 direction)
    {
        _direction=direction;

        transform.Rotate(0f, 0f, deltaDegrees);
    }
}
