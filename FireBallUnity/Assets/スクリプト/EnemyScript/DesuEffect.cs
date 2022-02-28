using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesuEffect : MonoBehaviour
{
    private Rigidbody2D myrigid;
    
    void Start()
    {
        myrigid = GetComponent<Rigidbody2D>();
        myrigid.AddForce(new Vector2(0, 10));
        Destroy(gameObject, 1.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
