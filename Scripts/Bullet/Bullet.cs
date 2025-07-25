using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Vector2 _direction;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void SetDirection( Vector2 direction)
    {
        _direction=direction;
        
        if(gameObject.TryGetComponent<SpriteRenderer>(out SpriteRenderer spriteRenderer))
        {
            spriteRenderer.flipX = _direction.x > 0;
        }
    }
}
