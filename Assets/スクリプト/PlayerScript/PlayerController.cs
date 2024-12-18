using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public Animator anim;
    int stop = 0;
    public PlayerStatus playerStatus;
    public GameObject[] enemys;
    public GameObject[] fireBalls;
    public GameObject kougekiHanniCanvas;
    public GameObject kinnsetusenntouButton;
    public KougekiHanniCircle kougekiHanniCircle;
    bool a;
    bool b;
    public bool c;
    bool d;
    bool e;

    public AudioSource audioSource;
    public GameObject damageHanntei;
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        playerStatus = GetComponent<PlayerStatus>();
        a = true;
        b = true;
        c = false;
        d = false;
        e = true;
        audioSource.volume = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<BGMSEVolume>().seVolume;

    }

    void Update()
    {
        stop = anim.GetInteger("Stop");
        if (a)
        {
            GameHanntei();
        }
        if(d)
        {
            myRigid.AddForce((transform.up) * -150, ForceMode2D.Force);
            audioSource.Play();
            a = false;
            d = false;
        }
        if (e)
        {
            if (enemys.Length == 0)
            {
                kinnsetusenntouButton.SetActive(false);
                myRigid.AddForce((transform.up) * -150, ForceMode2D.Force);
                a = false;
                e = false;
            }
        }

    }
    public void GameHanntei()
    {
        fireBalls = GameObject.FindGameObjectsWithTag("FireBall");
        enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (fireBalls.Length == 0)
        {
            if (playerStatus.mp < playerStatus.fireBallCost)
            {
                if (fireBalls.Length == 0)
                {
                    kinnsetusenntouButton.SetActive(false);
                    myRigid.AddForce((transform.up) * -150, ForceMode2D.Force);
                    a = false;
                    if(enemys.Length!=0) DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().KinnkyoriBGMStart();

                }
            }
        }
    }
    public void KinnsetuSenntou()
    {
        
        d = true;
        kinnsetusenntouButton.SetActive(false);
        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().KinnkyoriBGMStart();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "LowWall")
        {

            stop += 2;
            anim.SetInteger("Stop", stop);
            myRigid.velocity = Vector2.zero;
            audioSource.Stop();
            kougekiHanniCanvas.SetActive(true);
            if (enemys.Length == 0)
            {
                Debug.Log("近接戦闘に移行！！");
            }
            if (b)
            {
                Instantiate(damageHanntei);
                b = false;
                c = true;
                
            }

        }
    }
    

}
