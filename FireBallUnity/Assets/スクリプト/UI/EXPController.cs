using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPController : MonoBehaviour
{
    private GameObject player;
    private GameObject expManegar;
    private EXPManager expManagerScript;
    private Vector2 playerPosition;
    private Vector2 expPosition;
    public int exp;
    private GameObject resultManager;

    void Start()
    {
        player = GameObject.Find("Player");
        expManegar = GameObject.Find("DataBaseManager");
        resultManager = GameObject.Find("ResultManager");
        expManagerScript = expManegar.GetComponent<EXPManager>();

    }
    void Update()
    {
        if (player.transform.position.y < -2)
        {
            playerPosition = player.transform.position;
            expPosition = transform.position;

            expPosition.x += (playerPosition.x - expPosition.x) * 0.05f;
            expPosition.y += (playerPosition.y - expPosition.y) * 0.05f;
            transform.position = expPosition;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            expManagerScript.AddExp(exp);
            resultManager.GetComponent<ResultSceneManager>().kakutokuKeikennti += exp;
            Destroy(gameObject);
        }
    }
}
