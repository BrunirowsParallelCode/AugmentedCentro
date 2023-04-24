using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private bool _left = false, _right = false;
    [SerializeField] private float _speed;

    public void Left(bool value)
    {
        _left = value;
    }

    public void Right(bool value)
    {
        _right = value;
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Move(Vector3 velocity)
    {
        _rb.velocity = velocity;
    }

    private void Update()
    {
        if (_left) Move(Vector3.left * _speed);
        else if (_right) Move(Vector3.right * _speed);
        else _rb.velocity = Vector3.zero;

    }
}
