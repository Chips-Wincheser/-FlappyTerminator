using System;
using UnityEngine;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    private BirdMover _birdMover;

    private void Awake()
    {
        _birdMover = GetComponent<BirdMover>();
    }

}
