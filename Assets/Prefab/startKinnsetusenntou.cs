using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startKinnsetusenntou : MonoBehaviour
{
    public float startTime;
    public GameObject player;
    public bool a = true;

    public float nokoriTime;
    public Text nokoriTimeText;

    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        startTime += Time.deltaTime;
        if (startTime >= 60)
        {
            if (a)
            {
                player.GetComponent<PlayerController>().KinnsetuSenntou();
                a = false;
            }
        }
        nokoriTime = Mathf.FloorToInt(60 - startTime);
        nokoriTimeText.text = nokoriTime.ToString();
    }
}
