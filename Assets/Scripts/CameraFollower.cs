using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Vector3 _distance;
    [SerializeField] private float _smoothing;

    private void FixedUpdate()
    {
       Move();
    }

    private void Move()
    {
        var nextPosition = Vector3.Lerp(transform.position, _playerTransform.position + _distance,
            Time.fixedDeltaTime * _smoothing);
        transform.position = nextPosition;
    }
}
