using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOBACK : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene(8);
    }
}