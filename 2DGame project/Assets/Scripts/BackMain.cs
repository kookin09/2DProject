using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMain : MonoBehaviour
{
    public void BackScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
