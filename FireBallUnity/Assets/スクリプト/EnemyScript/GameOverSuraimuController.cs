using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSuraimuController : MonoBehaviour
{
    public float enemySpeed = 150;
    public float enemyIdoukyori = 1;
    private Rigidbody2D myRigid;
    public int sinnkouHoukou;
    public GameObject fireBallEffect;
    
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        sinnkouHoukou = Random.Range(1, 5);
        if (sinnkouHoukou == 1)
        {
            myRigid.AddForce((transform.up) * enemySpeed, ForceMode2D.Force);
        }
            if (sinnkouHoukou == 2)
        {
            myRigid.AddForce((transform.up) * -enemySpeed, ForceMode2D.Force);
        }
        if (sinnkouHoukou == 3)
        {
            myRigid.AddForce((transform.right) * enemySpeed, ForceMode2D.Force);
        }
        if (sinnkouHoukou == 4)
        {
            myRigid.AddForce((transform.right) * -enemySpeed, ForceMode2D.Force);
        }
    }

    void Update()
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //�G���m���Ԃ��������̐i�H�ύX
        sinnkouHoukou = Random.Range(1, 5);
        if (collision.gameObject.tag == "Enemy")
        {
            if (sinnkouHoukou == 1)
            {
                myRigid.AddForce((transform.up) * enemySpeed, ForceMode2D.Force);
            }
            if (sinnkouHoukou == 2)
            {
                myRigid.AddForce((transform.up) * -enemySpeed, ForceMode2D.Force);
            }
            if (sinnkouHoukou == 3)
            {
                myRigid.AddForce((transform.right) * enemySpeed, ForceMode2D.Force);
            }
            if (sinnkouHoukou == 4)
            {
                myRigid.AddForce((transform.right) * -enemySpeed, ForceMode2D.Force);
            }
        }
        if (collision.gameObject.tag == "Tawn")
        {
            //�t�@�C���[�{�[���̃G�t�F�N�g����
            Instantiate(fireBallEffect, transform.position, transform.rotation);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //�ǂɓ����������̐i�H�ύX
        sinnkouHoukou = Random.Range(1, 4);
        if (collision.gameObject.tag == "UpWall")
        {

            //�������Ɉړ�
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(0, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //�E�������Ɉړ�
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //���������Ɉړ�
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }

        }
        if (collision.gameObject.tag == "LowWall")
        {
            //������Ɉړ�
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(0, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //�E������Ɉړ�
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //��������Ɉړ�
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
        }
        if (collision.gameObject.tag == "RightWall")
        {
            //�������Ɉړ�
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, 0) * enemySpeed, ForceMode2D.Force);
            }
            //��������Ɉړ�
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //���������Ɉړ�
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
        }
        if (collision.gameObject.tag == "LeftWall")
        {
            //�E�����Ɉړ�
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, 0) * enemySpeed, ForceMode2D.Force);
            }
            //�E������Ɉړ�
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //�E�������Ɉړ�
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
        }
    }
}
