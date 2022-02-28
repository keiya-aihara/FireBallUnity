using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    public string giftName;
    public int giftBairitu;
    private GameObject player;
    private GameObject resaultManagar;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        resaultManagar = GameObject.Find("ResultManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y<=2)
        {
            resaultManagar.GetComponent<ResultSceneManager>().gifts.Add(gameObject);
            gameObject.SetActive(false);
        }
    }
}
