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
        text.text = "–‚—Í" + playerStatus.maryoku + ":" + "MP" + playerStatus.mp + "/" + playerStatus.maxMp;
    }
}
