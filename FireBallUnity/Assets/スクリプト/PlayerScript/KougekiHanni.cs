using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KougekiHanni : MonoBehaviour
{
    public CircleCollider2D kougekiHanniCollider;
    public PlayerStatus playerStatus;
    void Start()
    {
        kougekiHanniCollider.radius = playerStatus.kougekiHanni;
    }
    void Update()
    {
            
    }
}
