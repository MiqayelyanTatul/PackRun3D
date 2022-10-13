using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int _turnSpeed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (_speed * Time.fixedDeltaTime));
        float _translation = Input.GetAxis("Horizontal") * _turnSpeed;
        _translation *= Time.fixedDeltaTime;
        transform.Translate(_translation,0,0);
    }
}
