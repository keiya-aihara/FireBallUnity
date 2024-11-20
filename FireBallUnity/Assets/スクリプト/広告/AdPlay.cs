using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdPlay : MonoBehaviour
{
    public AdsInitializer adsInitializer;
    void Start()
    {
        adsInitializer = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<AdsInitializer>();
    }

    public void BottunDown()
    {
        adsInitializer.ShowAd();

    }
}
