using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    public GameObject player;
    private PlayerStatus playerStatus;
    public float playerKougeki;
    public Vector3 atackPosition;
    public float atackMotion;
    private Animator anim;
    private int attack;
    private SrashEffect effectTime;

    [Header("武器の番号。インスペクターで指定する")]
    public int weponNo;

    [Header("武器の情報。番号で検索して、スクリプタブル・オブジェクトから取得する")]
    public WeponDataList.WeponData weponData;
    void Start()
    {
        getInstance();
        syokitiSettei();
    }
    private void getInstance()
    {
        playerStatus = player.GetComponent<PlayerStatus>();
        anim = player.GetComponent<Animator>();
        weponNo = playerStatus.weponNo;
        weponData = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<WeponDateBaseManager>().GetWeponData(weponNo);
        effectTime = weponData.srushEffect.GetComponent<SrashEffect>();
    }
    private void syokitiSettei()
    {
        attack = 0;
        playerKougeki = 0;
    }

    // Update is called once per frame
    void Update()
    {
        attack = anim.GetInteger("Attack");
        playerAtackTime();
    }

    private void playerAtackTime()//Playerの攻撃頻度や攻撃行動の時間を管理するメソッド
    {
        if (player.transform.position.y <= 4)//playerが現れたら
        {
            playerKougeki += Time.deltaTime;
            atackMotion += Time.deltaTime;
        }
        if (transform.position.y <= -6f)
        {
            if (atackMotion >= playerStatus.destroyTime)
            {
                attack -= 2;
                anim.SetInteger("Attack", attack);

                atackPosition.y += 0.3f;
                player.transform.position = atackPosition;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerAtack();
        }
    }

    private void playerAtack()//アタック時のエフェクトの表示や前方移動のメソッド
    {
        if (playerKougeki > playerStatus.kougekiHinndo)
        {
            attack += 2;
            anim.SetInteger("Attack", attack);
            Instantiate(weponData.srushEffect,transform.position,transform.rotation,gameObject.transform);
            playerKougeki = 0;
            atackPosition = player.transform.position;
            atackPosition.y -= 0.3f;
            player.transform.position = atackPosition;
            atackMotion = 0f;
        }
    }
}

