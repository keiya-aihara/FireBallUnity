using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    private GameObject player;

    private Rigidbody2D myrigid;

    public int kinngaku;

    private GameObject moneyManger;
    private MoneyManager moneyManagerScript;

    private Vector2 playerPosition;
    private Vector2 moneyPosition;

    private GameObject resultManager;
    // Start is called before the first frame update
    void Start()
    {
        myrigid = GetComponent<Rigidbody2D>();
        myrigid.AddForce ( new Vector2(Random.Range(50, -51), Random.Range(50, -51)));
        moneyManger = GameObject.Find("DataBaseManager");
        moneyManagerScript = moneyManger.GetComponent<MoneyManager>();
        player = GameObject.Find("Player");
        resultManager = GameObject.Find("ResultManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -2)
        {
            playerPosition = player.transform.position;
            moneyPosition = transform.position;

            moneyPosition.x += (playerPosition.x - moneyPosition.x) * 0.05f;
            moneyPosition.y += (playerPosition.y - moneyPosition.y) * 0.05f;
            transform.position = moneyPosition;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            moneyManagerScript.AddMoney(kinngaku);
            resultManager.GetComponent<ResultSceneManager>().kakutokuCoin += kinngaku;

            Destroy(gameObject);
        }
    }
}
