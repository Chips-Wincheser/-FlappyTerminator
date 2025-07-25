using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<ScoreCounter>(out ScoreCounter scoreCounter))
        {
            scoreCounter.Add();
        }
    }
}
