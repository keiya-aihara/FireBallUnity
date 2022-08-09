using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallDestroy : MonoBehaviour
{
    Vector3 nokkubakku;
    EnemyBase enemyBase;
    CapsuleCollider2D capsuleCollider2D;
    float capusuleCollider2DY;
    Vector2 gameobjectPosition;
    private GameObject comboCounter;
    public GameObject bomEffectGameObject;
    public bool nomalBall;
    public bool spireBall;
    public bool rapidBall;
    public bool bomBall;
    public bool bomEffect;

    public int kanntuuKakuritu;
    public int kanntuuGennsuiritu;

    public int rapidKakuritu;
    public int rapidGennsuiritu;
    public Rigidbody2D rapidRigid;

    public int bakuhatuKakuritu;
    public float bakuhatuGennsuiBairitu;
    public int collisionEnterCount;

    private Vector2 ballPosition;
    // Start is called before the first frame update
    void Start()
    {
        comboCounter = GameObject.Find("ComboCounter");
        nokkubakku = new Vector3(0, -0.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
        ballPosition = transform.position;
        if(ballPosition.x<=-2.4f)
        {
            rapidRigid.velocity = Vector2.zero;
            ballPosition.x = -2.3f;
            transform.position = ballPosition;
        }
        else if (ballPosition.x >= 2.4f)
        {
            rapidRigid.velocity = Vector2.zero;
            ballPosition.x = 2.3f;
            transform.position = ballPosition;
        }
        else if (ballPosition.y >= 5.1f)
        {
            rapidRigid.velocity = Vector2.zero;
            ballPosition.y = 5;
            transform.position = ballPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "LowWall")
        {
            Destroy(gameObject,0.001f);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            if (nomalBall)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().comboCount++;
                enemyBase = collision.GetComponent<EnemyBase>();
                enemyBase.i = true;

                Destroy(gameObject);
            }
            else if(spireBall)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().comboCount++;
                enemyBase = collision.GetComponent<EnemyBase>();
                enemyBase.i = true;
                capsuleCollider2D = collision.GetComponent<CapsuleCollider2D>();
                if (kanntuuKakuritu > Random.Range(0, 100))
                {
                    capusuleCollider2DY = capsuleCollider2D.size.y / 10;
                    gameobjectPosition = gameObject.transform.position;
                    gameobjectPosition.y -= capusuleCollider2DY;
                    gameObject.transform.position = gameobjectPosition;
                    kanntuuKakuritu -= kanntuuGennsuiritu;
                    Debug.Log("貫通した");
                }
                else Destroy(gameObject);
            }
            else if(rapidBall)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().comboCount++;
                enemyBase = collision.GetComponent<EnemyBase>();
                enemyBase.i = true;
                capsuleCollider2D = collision.GetComponent<CapsuleCollider2D>();
                if (rapidKakuritu > Random.Range(0, 100))
                {
                    rapidKakuritu -= rapidGennsuiritu;
                    Debug.Log("跳ねた");
                }
                else Destroy(gameObject);
            }
            else if(bomBall)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().comboCount++;
                enemyBase = collision.GetComponent<EnemyBase>();
                enemyBase.i = true;
                capsuleCollider2D = collision.GetComponent<CapsuleCollider2D>();
                if (bakuhatuKakuritu > Random.Range(0, 100))
                {
                    Instantiate(bomEffectGameObject, transform.position, transform.rotation);
                    bakuhatuKakuritu = Mathf.FloorToInt(bakuhatuKakuritu * bakuhatuGennsuiBairitu);
                    Debug.Log(bakuhatuKakuritu);
                    Destroy(gameObject);
                }
                else
                {
                    bakuhatuKakuritu = Mathf.FloorToInt(bakuhatuKakuritu * bakuhatuGennsuiBairitu);
                    collisionEnterCount++;
                    if(collisionEnterCount==3)
                    {
                        collisionEnterCount = 0;
                        Destroy(gameObject);
                    }
                }
            }
            else if(bomEffect)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().comboCount++;
                enemyBase = collision.GetComponent<EnemyBase>();
                enemyBase.i = true;

                Destroy(gameObject,0.5f);
            }
        }
        else if(collision.gameObject.tag=="FireWall")
        {
            //Debug.Log(comboCounter.GetComponent<ComboCounter>().fireWallComboCount);
            if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().fireWallComboCount++;
        }
    }
}
