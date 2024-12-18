using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZidousyuukaiButton : MonoBehaviour
{
    public Text zidouTimeText;
    private float zidouTime;
    public BottonSceneCange bottonSceneCange;
    private void Start()
    {
        zidouTime = 3;
    }
    private void Update()
    {
        if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>().zidouSyuukai)
        {
            zidouTime -= Time.deltaTime;
            zidouTimeText.text = zidouTime.ToString("f0");
            if (zidouTime <= 0)
                bottonSceneCange.SaidoBoukennsuru();
        }
    }
}
