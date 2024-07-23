using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movament : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;
    [SerializeField] private Vector3 _scaleChange;
    [SerializeField] private Vector3 _rotateDirection;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Rotate();
        Grow();
    }

    private void Move()
    {
        _rigidbody.velocity = transform.forward * _speedMove * Time.deltaTime;
    }

    private void Rotate()
    {
        transform.Rotate(_rotateDirection * Time.deltaTime * _speedRotation, Space.World);
    }

    private void Grow()
    {
        transform.localScale += _scaleChange * Time.deltaTime;
    }
}
