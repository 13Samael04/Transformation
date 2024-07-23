using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _speedRotation;
    [SerializeField] private Vector3 _scaleChange;

    private void Update()
    {
        Move();
        Rotate();
        Grow();
    }

    private void Move()
    {
        transform.position += _movementDirection * Time.deltaTime;
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, Vector3.up, _speedRotation * Time.deltaTime);
    }

    private void Grow()
    {
        transform.localScale += _scaleChange * Time.deltaTime;
    }
}
