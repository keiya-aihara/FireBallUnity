﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZousyokukabeInstantiateFireBall : MonoBehaviour
{
    public GameObject fireBall;
    private Rigidbody2D fireBallRigid;
    ZousyokukabeStatus zousyokuBairitu;
    private GameObject[] fireBalls;
    /*
    // Start is called before the first frame update
    void Start()
    {
        zousyokuBairitu = gameObject.GetComponent<ZousyokukabeStatus>();
        fireBallRigid = fireBall.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        fireBalls= GameObject.FindGameObjectsWithTag("FireBall");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (fireBalls.Length <= 500)
        {
            if (collision.gameObject.tag == "FireBall")
            {
                    for (float n = 0; zousyokuBairitu.zousyokusuu > n; n += 1)
                    {
                        Instantiate(fireBall, new Vector3(collision.transform.position.x + Random.Range(-0.2f, 0.2f), collision.transform.position.y - 0.5f, transform.position.z), transform.rotation);
                    }
            }
        }
    }
    */
}

