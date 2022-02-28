using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKougekiHanniBase : MonoBehaviour
{
    private GameObject enemy;
    private EnemyBase enemyBase;
    private CircleCollider2D enemyKougekiHanniCollider;
    void Start()
    {
        enemy = transform.root.gameObject;
        enemyBase = enemy.GetComponent<EnemyBase>();
        enemyKougekiHanniCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyKougekiHanniCollider.radius = enemyBase.enemyData.kougekiHanni;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            enemyBase.b = false;
            enemyBase.g = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            enemyBase.b = true;
            enemyBase.g = false;
        }
    }
}
