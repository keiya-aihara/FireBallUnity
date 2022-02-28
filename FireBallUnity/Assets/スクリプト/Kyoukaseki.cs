using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyoukaseki : MonoBehaviour
{
    private GameObject player;
    private GameObject moneyManager;
    private GameObject resultManager;
    private Vector2 playerPosition;
    private Vector2 kyoukasekiPosition;
    public bool kyoukasekiSyou;
    public bool kyoukasekiTyuu;
    public bool kyoukasekiDai;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        moneyManager = GameObject.Find("DataBaseManager");
        resultManager = GameObject.Find("ResultManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -2)
        {
            playerPosition = player.transform.position;
            kyoukasekiPosition = transform.position;

            kyoukasekiPosition.x += (playerPosition.x - kyoukasekiPosition.x) * 0.05f;
            kyoukasekiPosition.y += (playerPosition.y - kyoukasekiPosition.y) * 0.05f;
            transform.position = kyoukasekiPosition;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            if(kyoukasekiSyou)
            {
                moneyManager.GetComponent<KyoukasekiManager>().kyoukasekiSyou += 1;
                resultManager.GetComponent<ResultSceneManager>().kakutokuKyoukasekiSyou += 1;
            }
            else if(kyoukasekiTyuu)
            {
                moneyManager.GetComponent<KyoukasekiManager>().kyoukasekiTyuu += 1;
                resultManager.GetComponent<ResultSceneManager>().kakutokuKyoukasekiTyuu += 1;
            }
            else
            {
                moneyManager.GetComponent<KyoukasekiManager>().kyoukasekiDai += 1;
                resultManager.GetComponent<ResultSceneManager>().kakutokuKyoukasekiDai += 1;
            }
            Destroy(gameObject);
        
        }
    }
}
