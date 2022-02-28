using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMpSlider : MonoBehaviour
{
    private Slider slider;
    public GameObject player;
    private PlayerStatus playerStatus;

    // Start is called before the first frame update
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        playerStatus = player.GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = playerStatus.maxMp;
        slider.value = playerStatus.mp;
        if(player.transform.position.y <= -4)
        {
            Destroy(gameObject);
        }
    }
}
