using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuraimuController : MonoBehaviour
{
    
    Vector2 force = new Vector2(1f, 1f);    // óÕÇê›íË
    private Rigidbody2D myRigid;
    EnemyBase enemyStatus;
    private GameObject player;
    int a;
    void Start()
    {
        player = GameObject.Find("Player");
        myRigid = GetComponent<Rigidbody2D>();
        enemyStatus = GetComponent<EnemyBase>();
        force *= 100;

        myRigid.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (player != null)
        {
            if (player.transform.position.y > 4)
            {

                if (collision.gameObject.tag == "UpWall")
                {
                    a = Random.Range(0, 2);
                    if (a == 0)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(-1f, -1f) * enemyStatus.enemyData.speed);
                    }
                    if (a == 1)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(1f, -1f) * enemyStatus.enemyData.speed);
                    }
                }
                if (collision.gameObject.tag == "LowWall")
                {
                    a = Random.Range(0, 2);
                    if (a == 0)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(-1f, 1f) * enemyStatus.enemyData.speed);
                    }
                    if (a == 1)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(1f, 1f) * enemyStatus.enemyData.speed);
                    }
                }
            }
        }
        else
        {
            myRigid.velocity = Vector2.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player != null)
        {
            if (player.transform.position.y > 4)
            {
                if (collision.gameObject.tag == "LeftWall")
                {
                    a = Random.Range(0, 4);
                    if (a <= 1)
                    {
                        return;
                    }
                    if (a == 2)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(1f, 1f) * enemyStatus.enemyData.speed);
                    }
                    if (a == 3)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(1f, -1f) * enemyStatus.enemyData.speed);
                    }
                }
                if (collision.gameObject.tag == "RightWall")
                {
                    a = Random.Range(0, 4);
                    if (a <= 1)
                    {
                        return;
                    }
                    if (a == 2)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(-1f, 1f) * enemyStatus.enemyData.speed);
                    }
                    if (a == 3)
                    {
                        myRigid.velocity = Vector2.zero;
                        myRigid.AddForce(new Vector2(-1f, -1f) * enemyStatus.enemyData.speed);
                    }
                }
            }
        }
        else
        {
            myRigid.velocity = Vector2.zero;
        }
    }
}
