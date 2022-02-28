using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallDestroy : MonoBehaviour
{
    Vector3 nokkubakku;
    EnemyBase enemyBase;
    
    // Start is called before the first frame update
    void Start()
    {
        nokkubakku = new Vector3(0, -0.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "LowWall")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            enemyBase = collision.GetComponent<EnemyBase>();
            enemyBase.i = true;
            Destroy(gameObject);
            
        }
    }
}
