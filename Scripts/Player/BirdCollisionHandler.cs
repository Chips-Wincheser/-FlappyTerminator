using UnityEngine;
using UnityEngine.UI;

public class BirdCollisionHandler : MonoBehaviour
{
    [SerializeField] private Button _respawnButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Ground>(out _) || collision.TryGetComponent<Bullet>(out _))
        {
            _respawnButton.gameObject.SetActive(true);
            GameStoper.StopTime();
        }
    }
}
