using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    public void OnClickReplay()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
