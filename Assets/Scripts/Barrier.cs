using System;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private const string _minus = "Minus";
    private const string _minus6 = "Minus6";
    private const string _minus10 = "Minus10";
    private const string _divider = "Divider";

    private void Awake()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Collector.singletone.Count <= 0)
        {
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_minus) )
        {
            Collector.singletone.Count -= 5;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag(_divider))
        {
            Collector.singletone.Count /= 2;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(_minus6))
        {
            Collector.singletone.Count -= 6;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag(_minus10))
        {
            Collector.singletone.Count -= 10;
            Destroy(collision.gameObject);
        }
    }
}
