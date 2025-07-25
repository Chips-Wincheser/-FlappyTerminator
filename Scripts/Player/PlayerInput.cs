using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private int LeftMouseButton = 0;
    private int RightMouseButton = 1;

    public event Action Jumping;
    public event Action Attaking;

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            Jumping?.Invoke();
        }

        if (Input.GetMouseButtonDown(RightMouseButton))
        {
            Attaking?.Invoke();
        }
    }
}
