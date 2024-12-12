using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaruRigid : MonoBehaviour
{
    public CapsuleCollider2D capsuleCollider2D;
    public Rigidbody2D rigidbody2D;
    public bool boundTaru;
    public float min;
    public float max;
    public float y;

    public float destroyTime;
    public float time;
    private void Start()
    {
        if(boundTaru)
        {
            rigidbody2D.AddForce(new Vector2(Random.Range(min, max), y));
        }
    }
    private void Update()
    {
        if(boundTaru)
        {
            time += Time.deltaTime;
            if (time >= destroyTime)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LowWall")
        {
            Destroy(gameObject, 0.001f);
        }
    }
}
