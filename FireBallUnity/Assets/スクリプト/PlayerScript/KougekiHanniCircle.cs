using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KougekiHanniCircle : MonoBehaviour
{
    public GameObject player;
    public GameObject kougekiHanni;
    public PlayerStatus playerStatus;
    public Vector2 kougekiHanniCircleScale;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        kougekiHanniCircleScale = gameObject.GetComponent<RectTransform>().sizeDelta;
        a = false;

        kougekiHanniCircleScale = new Vector2(playerStatus.kougekiHanni * 2, playerStatus.kougekiHanni * 2);
        GetComponent<RectTransform>().sizeDelta = kougekiHanniCircleScale;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
