using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private GameObject player;
    private EnemyBase enemyStatus;
    private float damageBairitu;
    private int saiteihosyouDamage;
    private float damageKeisann;
    private PlayerStatus playerStatus;
    public int playerDamage;
    public GameObject damageEffect;

    public bool a;
    public bool b;
    private bool c;

    private SpriteRenderer sprite;
    private float flashTime;
    private float flashColor;
    private float flashCount;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerStatus = player.GetComponent<PlayerStatus>();
        a = true;
        b = false;
        c = false;

        sprite = player.GetComponent<SpriteRenderer>();
        flashCount = 0;
        flashTime = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = player.transform.position;
            if (c)
            {
                flashCount += Time.deltaTime;
                DamageFlash();
                if (flashCount >= flashTime)
                {
                    sprite.color = new Color(255, 255, 255, 255);
                    flashCount = 0;
                    c = false;
                }
            }
        }
    }
    public void DamageFlash()
    {
        flashColor = Mathf.Sin(Time.time * 100) / 2 + 0.5f;
        Color color = sprite.color;
        color.a = flashColor;
        sprite.color = color;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (a)
            {
                Instantiate(damageEffect, transform.position, transform.rotation);
                a = false;
                b = true;
                c = true;
                enemyStatus = collision.GetComponent<EnemyBase>();
                damageBairitu = Random.Range(0.8f, 1.21f);
                saiteihosyouDamage = Random.Range(0, 2);
                damageKeisann = (enemyStatus.enemyData.kougekiryoku - playerStatus.bougyoryoku) * damageBairitu;
                if (damageKeisann < 1)
                {
                    playerDamage = saiteihosyouDamage;
                    playerStatus.hp -= playerDamage;
                    Debug.Log(enemyStatus.enemyData.enemyName + "から最低保証" + saiteihosyouDamage + "のダメージをうけた");
                }
                else
                {
                    playerDamage = Mathf.CeilToInt(damageKeisann);
                    playerStatus.hp -= playerDamage;
                    Debug.Log(enemyStatus.enemyData.enemyName + "から" + playerDamage + "のダメージを受けた");
                }
                if (playerStatus.hp <= 0)
                {
                    Destroy(player.gameObject);
                }
            }
        }
    }
}
