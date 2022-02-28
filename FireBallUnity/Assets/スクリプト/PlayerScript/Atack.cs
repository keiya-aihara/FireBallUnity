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

    [Header("����̔ԍ��B�C���X�y�N�^�[�Ŏw�肷��")]
    public int weponNo;

    [Header("����̏��B�ԍ��Ō������āA�X�N���v�^�u���E�I�u�W�F�N�g����擾����")]
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

    private void playerAtackTime()//Player�̍U���p�x��U���s���̎��Ԃ��Ǘ����郁�\�b�h
    {
        if (player.transform.position.y <= 4)//player�����ꂽ��
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

    private void playerAtack()//�A�^�b�N���̃G�t�F�N�g�̕\����O���ړ��̃��\�b�h
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

