using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth2 : MonoBehaviour
{


    void Update()
    {
        if (gameObject.transform.position.y <= -7)
        {
            SceneManager.LoadScene(3);
        }
    }
}
