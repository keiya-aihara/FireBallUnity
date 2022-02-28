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
    public KougekiHanniCircle kougekiHanniCircle;
    bool a;
    bool b;
    public bool c;
    bool d;
    bool e;

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
            a = false;
            d = false;
        }
        if (e)
        {
            if (enemys.Length == 0)
            {
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
                            myRigid.AddForce((transform.up) * -150, ForceMode2D.Force);
                            a = false;
                    }
                }
            }
    }
    public void KinnsetuSenntou()
    {
        d = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "LowWall")
        {
            if(enemys == null)
            {
                   
            }
            stop += 2;
            anim.SetInteger("Stop", stop);
            myRigid.velocity = Vector2.zero;
            kougekiHanniCanvas.SetActive(true);
            if (enemys.Length == 0)
            {
                Debug.Log("‹ßÚí“¬‚ÉˆÚsII");
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
