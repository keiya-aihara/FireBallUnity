using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Rigidbody2D myRigid;
    public GameObject player;
    bool a = true;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (player.transform.position.y <= 4)
            {
                if (a)
                {
                    myRigid.AddForce((transform.up) * -150, ForceMode2D.Force);
                    a = false;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LowWall")
        {
            myRigid.velocity = Vector2.zero;
        }
    }
}
