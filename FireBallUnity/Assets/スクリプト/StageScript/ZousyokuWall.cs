using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZousyokuWall : MonoBehaviour
{
    public GameObject fireBall;
    public int zousyokuSuu;
    public GameObject[] fireBalls;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        fireBalls = GameObject.FindGameObjectsWithTag("FireBall");

        if (fireBalls.Length <= 100)
        {
            if (collision.gameObject.tag == "FireBall")
            {
                for (int a = 0; a < zousyokuSuu; a++)
                    Instantiate(fireBall, new Vector3(transform.position.x+Random.Range(-1.5f,1.5f),transform.position.y), transform.rotation);
            }
        }
    }
}
