using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuraimuController : MonoBehaviour
{
    
    Vector2 force;    // 力を設定
    private Rigidbody2D myRigid;
    EnemyBase enemyStatus;
    private GameObject player;
    int a;

    public bool move;
    public bool stop;

    void Start()
    {
        force.x = Random.Range(-1, 2);
        force.y = Random.Range(-1, 2);
        player = GameObject.Find("Player");
        myRigid = GetComponent<Rigidbody2D>();
        enemyStatus = GetComponent<EnemyBase>();
        force *= 100;

        if(move)             
            myRigid.AddForce(force);
        
        else if(stop)
            myRigid.velocity = Vector2.zero;
    }
    
    // Update is called once per frame
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (player != null)
        {
            if (player.transform.position.y > 4)
            {
                if (move)
                {
                    if (collision.gameObject.tag == "UpWall")
                    {
                        a = Random.Range(0, 2);
                        if (a == 0)
                        {
                            myRigid.velocity = Vector2.zero;
                            myRigid.AddForce(new Vector2(-1f, -1f) * enemyStatus.enemySpeed);
                        }
                        if (a == 1)
                        {
                            myRigid.velocity = Vector2.zero;
                            myRigid.AddForce(new Vector2(1f, -1f) * enemyStatus.enemySpeed);
                        }
                    }
                    if (collision.gameObject.tag == "LowWall")
                    {
                        a = Random.Range(0, 2);
                        if (a == 0)
                        {
                            myRigid.velocity = Vector2.zero;
                            myRigid.AddForce(new Vector2(-1f, 1f) * enemyStatus.enemySpeed);
                        }
                        if (a == 1)
                        {
                            myRigid.velocity = Vector2.zero;
                            myRigid.AddForce(new Vector2(1f, 1f) * enemyStatus.enemySpeed);
                        }
                    }
                }
                else if(stop)
                {
                    myRigid.velocity = Vector2.zero;

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
                if (move)
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
                            myRigid.AddForce(new Vector2(1f, 1f) * enemyStatus.enemySpeed);
                        }
                        if (a == 3)
                        {
                            myRigid.velocity = Vector2.zero;
                            myRigid.AddForce(new Vector2(1f, -1f) * enemyStatus.enemySpeed);
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
                            myRigid.AddForce(new Vector2(-1f, 1f) * enemyStatus.enemySpeed);
                        }
                        if (a == 3)
                        {
                            myRigid.velocity = Vector2.zero;
                            myRigid.AddForce(new Vector2(-1f, -1f) * enemyStatus.enemySpeed);
                        }
                    }
                }
                else if(stop)
                {
                    myRigid.velocity = Vector2.zero;

                }
            }
        }
        else
        {
            myRigid.velocity = Vector2.zero;
        }
    }
}
