using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpText : MonoBehaviour
{
    public GameObject player;
    private PlayerStatus playerStatus;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        playerStatus = player.GetComponent<PlayerStatus>();
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text ="HP" + playerStatus.hp + "/" + playerStatus.maxHp;
    }
}
