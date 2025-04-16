using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Vector2 _direction;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Bird>(out _) || collider.TryGetComponent<EnemyRemover>(out _))
        {
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out _))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
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
