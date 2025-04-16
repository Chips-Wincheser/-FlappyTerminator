using System;
using UnityEngine;
using UnityEngine.UI;

public class BirdCollisionHandler : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Ground>(out _) || collision.TryGetComponent<Bullet>(out _))
        {
            _button.gameObject.SetActive(true);
            GameStoper.GameOvering();
        }
    }
}
