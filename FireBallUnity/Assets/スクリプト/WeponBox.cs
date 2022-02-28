using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponBox : MonoBehaviour
{
    public GameObject itemPrefab;
    public ItemController itemPrefabStatus;

    public GameObject syougouPrefab;
    private GameObject gameManager;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager");
        itemPrefabStatus = itemPrefab.GetComponent<ItemController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y <= -2)
        {
            Instantiate(itemPrefab,transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
