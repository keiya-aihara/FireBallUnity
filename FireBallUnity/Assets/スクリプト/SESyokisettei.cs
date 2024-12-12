using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SESyokisettei : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        audioSource.volume = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<BGMSEVolume>().seVolume;   
    }
}
