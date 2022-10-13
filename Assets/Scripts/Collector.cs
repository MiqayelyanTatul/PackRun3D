using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
  public int Count = 1;
  [SerializeField] private TextMeshProUGUI _countText;
  private const string _sphere = "Sphere";
  public static Collector singletone { get; private set; }

  private void Awake()
  {
    if (!singletone)
    {
      singletone = this;
      DontDestroyOnLoad(this);
    }
    else
    {
      Destroy(gameObject);
    }
  }

  private void Update()
  {
    _countText.text = Count.ToString();
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag(_sphere))
    {
      Count ++;
      Destroy(other.gameObject);
    }
  }
}