using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager1 : MonoBehaviour
{
    public AudioSource music;
    void Start()
    {
        Time.timeScale = 1f;
        music.volume = PlayerPrefs.GetFloat("MusicVolume");
    }

}
