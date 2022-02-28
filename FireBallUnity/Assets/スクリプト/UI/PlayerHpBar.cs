using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHpBar : MonoBehaviour
{
    private Slider slider;
    public GameObject player;
    private PlayerStatus playerStatus;
    // Start is called before the first frame update
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        player = transform.root.gameObject;
        playerStatus = player.GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = playerStatus.maxHp;
        slider.value = playerStatus.hp;
    }
}
