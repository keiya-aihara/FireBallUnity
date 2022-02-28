using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerKougekiBar : MonoBehaviour
{
    public Slider slider;
    public PlayerStatus playerStatus;
    public Atack atack;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = playerStatus.kougekiHinndo;
        slider.value = atack.playerKougeki;
    }
}
