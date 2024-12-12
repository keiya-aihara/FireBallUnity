using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBar : MonoBehaviour
{
    private Slider slider;
    private GameObject enemy;
    private EnemyBase enemyBase;
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        enemy = transform.parent.parent.gameObject;
        enemyBase = enemy.GetComponent<EnemyBase>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = enemyBase.maxHp;
        slider.value = enemyBase.hp;

    }
}
