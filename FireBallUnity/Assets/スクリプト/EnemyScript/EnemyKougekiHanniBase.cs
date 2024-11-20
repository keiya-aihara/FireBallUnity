using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKougekiHanniBase : MonoBehaviour
{
    private GameObject enemy;
    private EnemyBase enemyBase;
    private CircleCollider2D enemyKougekiHanniCollider;
    private GameObject player;

    void Start()
    {
        enemyBase = gameObject.GetComponent<EnemyBase>();
        enemyKougekiHanniCollider = GetComponent<CircleCollider2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //enemyKougekiHanniCollider.radius = enemyBase.enemyData.kougekiHanni;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (player.transform.position.y <= -5)
        {
            if (collision.gameObject.tag == "EnemyKougekiWall")
            {
                enemyBase.collisionEnterLowLowWallBool = false;
                enemyBase.collisionEnterKougekiWallBool = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            enemyBase.collisionEnterLowLowWallBool = true;
            enemyBase.collisionEnterKougekiWallBool = false;
        }
    }
}
