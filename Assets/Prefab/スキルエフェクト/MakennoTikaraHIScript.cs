using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakennoTikaraHIScript : MonoBehaviour
{
    public Rigidbody2D makennnoTikaraHiRigidbody2D;
    public GameObject damageEffect;

    private void Start()
    {
        makennnoTikaraHiRigidbody2D.AddForce(new Vector2(Random.Range(-200, 200), -100));
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(damageEffect, collision.transform.position,transform.rotation);
        }
    }*/
}
