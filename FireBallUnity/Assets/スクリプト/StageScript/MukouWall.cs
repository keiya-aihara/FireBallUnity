using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MukouWall : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FireBall") Destroy(collision.gameObject);
    }
}
