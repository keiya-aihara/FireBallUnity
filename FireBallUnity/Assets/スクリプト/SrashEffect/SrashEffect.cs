using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrashEffect : MonoBehaviour
{
    private GameObject player;
    PlayerStatus playerStatus;
    public BoxCollider2D boxCollider2D;
    public RectTransform rectTransform;


    void Start()
    {
        player = gameObject.transform.root.gameObject;
        playerStatus = player.GetComponent<PlayerStatus>();
        rectTransform.sizeDelta = new Vector2(playerStatus.kougekiHanni, playerStatus.kougekiHanni);
        boxCollider2D.size = new Vector2(rectTransform.sizeDelta.x, boxCollider2D.size.y) ;
        boxCollider2D.offset = new Vector2 (playerStatus.kougekiHanni / -2,0);
        
        Destroy(gameObject,playerStatus.destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        transform.Rotate(new Vector3(0, 0, playerStatus.srushSpeed));
    }

}

