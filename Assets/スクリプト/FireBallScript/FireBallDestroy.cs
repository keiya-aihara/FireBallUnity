using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallDestroy : MonoBehaviour
{
    Vector3 nokkubakku;
    EnemyBase enemyBase;
    CapsuleCollider2D capsuleCollider2D;
    float capusuleCollider2DY;
    float enemyScale;

    public float destroyTime;

    Vector2 gameobjectPosition;
    Vector3 stopPosition;
    int stopCount;
    private Vector2 gameObjectPosition2;
    private GameObject comboCounter;
    public GameObject bomEffectGameObject;
    private GameObject player;
    public bool nomalBall;
    public bool spireBall;
    public bool rapidBall;
    public bool bomBall;
    public bool bomEffect;

    private ZousyokukabeStatus zousyokukabeStatus;
    public GameObject nomalBallObject;

    private float teisiTime;

    public int kanntuuKakuritu;
    public int kanntuuGennsuiritu;

    public int rapidKakuritu;
    public int rapidGennsuiritu;
    public Rigidbody2D rapidRigid;

    public int bakuhatuKakuritu;
    public float bakuhatuGennsuiBairitu;
    public int collisionEnterCount;

    private Vector2 ballPosition;
    private GameObject[] fireBalls;

    public GameObject fireBallEffect;
    private float taruTaime;
    // Start is called before the first frame update
    void Start()
    {
        comboCounter = GameObject.Find("ComboCounter");
        player = GameObject.Find("Player");
        nokkubakku = new Vector3(0, -0.3f, 0);

    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y <= -5)
        {
            Destroy(gameObject);
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
        if(player.transform.position.y<=5)
        {
            Destroy(gameObject);
        }
        fireBalls = GameObject.FindGameObjectsWithTag("FireBall");

        if (stopPosition == transform.position)
        {
            stopCount += 1;
           // Debug.Log("ストップカウント+1");
        }
        else
        {
            stopCount = 0;
           // Debug.Log("ストップカウントリセット");
        }
        if (stopCount >= 130)
        {
           // Debug.Log("ストップカウント200により、デストロイ");
            Destroy(gameObject);
        }

        stopPosition = transform.position;
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
                enemyBase.damageEffectBool = true;

                Destroy(gameObject);
            }
            else if(spireBall)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().comboCount++;
                enemyBase = collision.GetComponent<EnemyBase>();
                enemyBase.damageEffectBool = true;
                
                capsuleCollider2D = collision.GetComponent<CapsuleCollider2D>();
                
                if (kanntuuKakuritu > Random.Range(0, 100))
                {
                    enemyScale = collision.transform.localScale.y;
                    Debug.Log(enemyScale);
                    capusuleCollider2DY = capsuleCollider2D.size.y * enemyScale;
                    gameobjectPosition = gameObject.transform.position;
                    gameobjectPosition.y -= capusuleCollider2DY;
                    gameObject.transform.position = gameobjectPosition;
                    
                    /*
                    gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
                    */
                    kanntuuKakuritu -= kanntuuGennsuiritu;
                    Debug.Log("貫通した");
                }
                else Destroy(gameObject);
                
            }
            else if(rapidBall)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().comboCount++;
                enemyBase = collision.GetComponent<EnemyBase>();
                enemyBase.damageEffectBool = true;
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
                enemyBase.damageEffectBool = true;
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
                enemyBase.damageEffectBool = true;

                Destroy(gameObject,0.5f);
            }
        }
        else if(collision.gameObject.tag=="FireWall")
        {
            //Debug.Log(comboCounter.GetComponent<ComboCounter>().fireWallComboCount);
            if(comboCounter!=null)
            if (comboCounter.GetComponent<ComboCounter>().wallCombo)
            {
                if (comboCounter != null) comboCounter.GetComponent<ComboCounter>().fireWallComboCount++;
            }
        }
        else if (collision.gameObject.tag == "Siild")
        {
            Debug.Log("シールドに当たった");
            collision.gameObject.GetComponent<SiildScript>().siildHp--;
            Instantiate(fireBallEffect,collision.transform.position,transform.rotation);
            GameObject.Find("GameManager").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
        /*else if (collision.gameObject.tag == "Taru")
        {
            Debug.Log("樽に当たった");
            Destroy(collision.gameObject);
            taruEnterKaisuu--;

            if(taruEnterKaisuu<=0)
            Destroy(gameObject);
        }
        */
    }
    private void OnTriggerStay2D(Collider2D collision)
    {/*
        if (collision.gameObject.tag == "Enemy")
        {
            if (spireBall)
            {
                gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
            }
        }
        */
        if (collision.gameObject.tag == "Taru")
        {
            Debug.Log("樽に当たった");
            taruTaime += Time.deltaTime;

            if (taruTaime >= 3)
                Destroy(gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.gameObject.tag=="FireWall")
        {
            if (fireBalls.Length <= 200)
            {
                zousyokukabeStatus = collision.GetComponent<ZousyokukabeStatus>();
                if (nomalBall)
                {
                    for (float n = 0; zousyokukabeStatus.zousyokusuu > n; n += 1)
                        Instantiate(gameObject, new Vector3(gameObject.transform.position.x + Random.Range(-0.2f, 0.2f), gameObject.transform.position.y - 0.5f, transform.position.z), transform.rotation);
                }
                else if (spireBall)
                {
                    for (float n = 0; zousyokukabeStatus.zousyokusuu > n; n += 1)
                        Instantiate(gameObject, new Vector3(gameObject.transform.position.x + Random.Range(-0.2f, 0.2f), gameObject.transform.position.y - 0.5f, transform.position.z), transform.rotation);
                }
                else if(bomBall)
                {
                    for (float n = 0; zousyokukabeStatus.zousyokusuu > n; n += 1)
                        Instantiate(gameObject, new Vector3(gameObject.transform.position.x + Random.Range(-0.2f, 0.2f), gameObject.transform.position.y - 0.5f, transform.position.z), transform.rotation);
                }
                else if(rapidBall)
                {
                    for (float n = 0; zousyokukabeStatus.zousyokusuu > n; n += 1)
                        Instantiate(nomalBallObject, new Vector3(gameObject.transform.position.x + Random.Range(-0.2f, 0.2f), gameObject.transform.position.y - 0.5f, transform.position.z), transform.rotation);
                }
            }
        }
        else if(collision.gameObject.tag=="StageObject")
        {
            teisiTime = 0;
        }
    }
}
