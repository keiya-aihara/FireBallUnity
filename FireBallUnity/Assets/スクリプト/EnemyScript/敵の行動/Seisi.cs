using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seisi : MonoBehaviour
{
    public GameObject player;
    private Vector2 vector2;
    private void Start()
    {
        vector2 = transform.position;
    }
    void Update()
    {
        if(player.transform.position.y>=5.85f)
        transform.position = vector2;
    }
}
