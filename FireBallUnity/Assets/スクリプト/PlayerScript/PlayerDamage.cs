using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private GameObject player;
    private EnemyBase enemyStatus;
    private float damageBairitu;
    private int saiteihosyouDamage;
    private float damageKeisann;
    private PlayerStatus playerStatus;
    public int playerDamage;
    public GameObject damageEffect;
    public GameObject missText;
    public GameObject canvas;
    private float kaisinn;

    public bool a;
    public bool b;
    private bool c;
    public bool d;

    private float kaihi;

    private SpriteRenderer sprite;
    private float flashTime;
    private float flashColor;
    private float flashCount;

    private GameObject mainCameraCanvas;

    private GameObject dataBaseManager = DontDestroyOnloadDataBaseManager.DataBaseManager;

    private SoubiSkillDatabase soubiSkillDatabase;
    private bool damageKeigennBool;
    private SoubiSkillDataList.SoubiSkillData damageKeigennData;
    private bool sekikaHanngekiBool;
    private SoubiSkillDataList.SoubiSkillData sekikaHanngekiData;

    public AudioSource audioSource;
    public AudioClip damageClip;
    public AudioClip missClip;
    public AudioClip bougyoSkillClip;
    public AudioClip kaisinnClip;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerStatus = player.GetComponent<PlayerStatus>();
        a = true;
        b = false;
        c = false;

        sprite = player.GetComponent<SpriteRenderer>();
        flashCount = 0;
        flashTime = 0.3f;
        canvas = GameObject.Find("MainCameraCanvas");
        mainCameraCanvas = GameObject.Find("MainCameraCanvas");
        SoubiSkillSettei();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = player.transform.position;
            if (c)
            {
                flashCount += Time.deltaTime;
                DamageFlash();
                if (flashCount >= flashTime)
                {
                    sprite.color = new Color(255, 255, 255, 255);
                    flashCount = 0;
                    c = false;
                }
            }
        }
    }
    public void DamageFlash()
    {
        flashColor = Mathf.Sin(Time.time * 100) / 2 + 0.5f;
        Color color = sprite.color;
        color.a = flashColor;
        sprite.color = color;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (a)
            {
                
                Instantiate(damageEffect, transform.position, transform.rotation);
                a = false;
                
                c = true;
                enemyStatus = collision.GetComponent<EnemyBase>();

                kaihi = 100 - (enemyStatus.meityuuritu - playerStatus.kaihiritu);
                if (Random.Range(0.0f, 100.0f) <= kaihi)
                {
                    if (kaihi >= 95)
                    {
                        if (Random.Range(0.0f, 100.0f) <= 5)
                        {
                            b = true;
                            damageBairitu = Random.Range(0.8f, 1.21f);
                            saiteihosyouDamage = 1;
                            damageKeisann = (enemyStatus.kougekiryoku/2 - playerStatus.bougyoryoku/4) * damageBairitu;
                            if (damageKeisann < 1)
                            {
                                playerDamage = saiteihosyouDamage;
                                kaisinn = enemyStatus.kaisinnritu - playerStatus.kaisinntaisei;
                                if (kaisinn >= Random.Range(0.0f, 100.0f))
                                {
                                    audioSource.PlayOneShot(kaisinnClip);
                                    playerDamage *= 2;
                                    d = true;
                                }
                                audioSource.PlayOneShot(damageClip);
                                playerStatus.hp -= playerDamage;
                                //Debug.Log(enemyStatus.enemyData.enemyName + "から最低保証" + saiteihosyouDamage + "のダメージをうけた");
                            }
                            else
                            {
                                if(damageKeigennBool)
                                {
                                    if(Random.Range(0.0f,100.0f)<=damageKeigennData.damageKeigennKakuritu)
                                    {
                                        audioSource.PlayOneShot(bougyoSkillClip);
                                        Instantiate(soubiSkillDatabase.damageKeigennSkillText, new Vector3(0, -5f), transform.rotation, mainCameraCanvas.gameObject.transform);
                                        damageKeisann *= (1.00f - damageKeigennData.damageKeigennRitu / 100.00f);
                                        Debug.Log(damageKeisann);
                                    }
                                }
                                playerDamage = Mathf.CeilToInt(damageKeisann);
                                audioSource.PlayOneShot(damageClip);
                                playerStatus.hp -= playerDamage;
                                //Debug.Log(enemyStatus.enemyData.enemyName + "から" + playerDamage + "のダメージを受けた");
                            }
                            if (playerStatus.hp <= 0)
                            {
                                Destroy(player.gameObject);
                            }
                        }
                        else
                        {
                            audioSource.PlayOneShot(missClip);
                            Instantiate(missText, transform.position, transform.rotation,canvas.transform);
                        }
                    }
                    else
                    {
                        audioSource.PlayOneShot(missClip);
                        Instantiate(missText, transform.position, transform.rotation,canvas.transform);
                    }
                }
                else
                {
                    b = true;
                    damageBairitu = Random.Range(0.8f, 1.21f);
                    saiteihosyouDamage = 1;
                    damageKeisann = (enemyStatus.kougekiryoku/3 - playerStatus.bougyoryoku/3) * damageBairitu;
                    if (damageKeisann < 1)
                    {
                        playerDamage = saiteihosyouDamage;
                        kaisinn = enemyStatus.kaisinnritu - playerStatus.kaisinntaisei;
                        if (kaisinn >= Random.Range(0.0f, 100.0f))
                        {
                            audioSource.PlayOneShot(kaisinnClip);
                            playerDamage *= 2;
                            d = true;
                        }
                        audioSource.PlayOneShot(damageClip);
                        playerStatus.hp -= playerDamage;
                        //Debug.Log(enemyStatus.enemyData.enemyName + "から最低保証" + saiteihosyouDamage + "のダメージをうけた");
                    }
                    else
                    {
                        if (damageKeigennBool)
                        {
                            if (Random.Range(0.0f, 100.0f) <= damageKeigennData.damageKeigennKakuritu)
                            {
                                audioSource.PlayOneShot(bougyoSkillClip);
                                Instantiate(soubiSkillDatabase.damageKeigennSkillText, new Vector3(0, -5f), transform.rotation, mainCameraCanvas.gameObject.transform);
                                damageKeisann *= (1.00f - damageKeigennData.damageKeigennRitu / 100.00f);
                                //Debug.Log(damageKeisann);
                            }
                        }
                        playerDamage = Mathf.CeilToInt(damageKeisann);
                        kaisinn = enemyStatus.kaisinnritu - playerStatus.kaisinntaisei;
                        if (kaisinn >= Random.Range(0.0f, 100.0f))
                        {
                            audioSource.PlayOneShot(kaisinnClip);
                            playerDamage *= 2;
                            d = true;
                        }
                        audioSource.PlayOneShot(damageClip);
                        playerStatus.hp -= playerDamage;
                        //Debug.Log(enemyStatus.enemyData.enemyName + "から" + playerDamage + "のダメージを受けた");
                    }
                    if (playerStatus.hp <= 0)
                    {
                        Destroy(player.gameObject);
                    }
                }
                if(sekikaHanngekiBool)
                {
                    if(Random.Range(0.0f,100.0f)<=sekikaHanngekiData.sekikaHanngekiKakuritu)
                    {
                        audioSource.PlayOneShot(bougyoSkillClip);
                        Instantiate(soubiSkillDatabase.damageKeigennSkillText, new Vector3(0, -5f), transform.rotation, mainCameraCanvas.gameObject.transform);
                        enemyStatus.sekikaMode = true;
                    }
                }
            }
        }
    }
    private void SoubiSkillSettei()
    {
        soubiSkillDatabase = dataBaseManager.GetComponent<SoubiSkillDatabase>();
        for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
        {
            if (soubiSkillDatabase.skillNumber[a] == 4)//ダメージ軽減Lv.1
            {
                damageKeigennBool = true;
                damageKeigennData = soubiSkillDatabase.GetSoubiSkillData(4);
            }
            if (soubiSkillDatabase.skillNumber[a] == 10)//石化反撃Lv.1
            {
                sekikaHanngekiBool = true;
                sekikaHanngekiData = soubiSkillDatabase.GetSoubiSkillData(10);
            }
            if (soubiSkillDatabase.skillNumber[a] == 11)//ダメージ軽減Lv.2
            {
                damageKeigennBool = true;
                damageKeigennData = soubiSkillDatabase.GetSoubiSkillData(11);
            }
        }
    }
}
