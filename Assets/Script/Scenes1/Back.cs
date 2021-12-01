using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void changeScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(8);
    }
}