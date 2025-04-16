using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action Jumping;
    public event Action Attaking;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jumping?.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Attaking?.Invoke();
        }
    }
}
