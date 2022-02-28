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
        //敵同士がぶつかった時の進路変更
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
            //ファイヤーボールのエフェクト処理
            Instantiate(fireBallEffect, transform.position, transform.rotation);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //壁に当たった時の進路変更
        sinnkouHoukou = Random.Range(1, 4);
        if (collision.gameObject.tag == "UpWall")
        {

            //下方向に移動
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(0, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //右下方向に移動
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //左下方向に移動
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }

        }
        if (collision.gameObject.tag == "LowWall")
        {
            //上方向に移動
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(0, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //右上方向に移動
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //左上方向に移動
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
        }
        if (collision.gameObject.tag == "RightWall")
        {
            //左方向に移動
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, 0) * enemySpeed, ForceMode2D.Force);
            }
            //左上方向に移動
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //左下方向に移動
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(-enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
        }
        if (collision.gameObject.tag == "LeftWall")
        {
            //右方向に移動
            if (sinnkouHoukou == 1)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, 0) * enemySpeed, ForceMode2D.Force);
            }
            //右上方向に移動
            if (sinnkouHoukou == 2)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
            //右下方向に移動
            if (sinnkouHoukou == 3)
            {
                myRigid.velocity = Vector2.zero;
                myRigid.AddForce(new Vector2(enemyIdoukyori, -enemyIdoukyori) * enemySpeed, ForceMode2D.Force);
            }
        }
    }
}
