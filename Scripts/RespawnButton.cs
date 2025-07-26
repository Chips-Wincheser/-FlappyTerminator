using UnityEngine;
using UnityEngine.UI;

public class RespawnButton : MonoBehaviour
{
    [SerializeField] private Button Button;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        Button.onClick.AddListener(HandleButtonClick);
    }

    private void OnDisable()
    {
        Button.onClick.RemoveListener(HandleButtonClick);
    }

    private void HandleButtonClick()
    {
        GameStoper.Respown();
    }
}
