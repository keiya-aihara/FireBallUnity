using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpWall : MonoBehaviour
{
    public GameObject inWarp;
    public GameObject outWarp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FireBall")
        {
            Instantiate(collision, new Vector2(outWarp.transform.position.x + Random.Range(-0.2f, 0.2f),outWarp.transform.position.y), transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}
