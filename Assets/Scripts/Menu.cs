using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    public void OnClickStart()
    {
        _panel.SetActive(false);
        Time.timeScale = 1;
    }
}
