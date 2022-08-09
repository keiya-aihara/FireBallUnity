using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMpText : MonoBehaviour
{
    private Text text;
    public GameObject player;
    private PlayerStatus playerStatus;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        playerStatus = player.GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "魔力 " + playerStatus.maryoku.ToString("N0")+"：コスト "+playerStatus.fireBallCost.ToString("N0") +  "\nMP" + playerStatus.mp.ToString("N0") + "/" + playerStatus.maxMp.ToString("N0");
    }
}
