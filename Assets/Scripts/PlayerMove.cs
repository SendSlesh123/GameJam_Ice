using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float speed = 3;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 moveDirection = Vector3.ClampMagnitude(new Vector3(Input.GetAxis("Horizontal"), _rigidbody.linearVelocity.y, Input.GetAxis("Vertical")), 1);
        _rigidbody.linearVelocity = moveDirection * speed;
    }
}
