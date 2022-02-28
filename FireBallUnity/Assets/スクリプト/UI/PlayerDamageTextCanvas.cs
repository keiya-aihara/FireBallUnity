using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamageTextCanvas : MonoBehaviour
{
    public Text damageText;
    private int damage;
    public GameObject damageHanni;
    private PlayerDamage playerDamage;
    private PlayerController playerController;
    public GameObject player;
    public GameObject canvas;
    private Vector3 popPosition;
    private float popSide;
    private bool a;
    private bool b;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        canvas = GameObject.Find("MainCameraCanvas");
        playerController = player.GetComponent<PlayerController>();
        a = true;
        b = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= -5)
        {
            if (a)
            {
                popPosition = player.transform.position;
                a = false;
                b = true;
            }
            if (playerController.c)
            {
                if (b)
                {
                    popSide = Random.Range(-1.5f, 1.51f);
                    popPosition.x = popSide;

                    damageHanni = GameObject.Find("DamageHanni(Clone)");
                    playerDamage = damageHanni.GetComponent<PlayerDamage>();
                    damage = playerDamage.playerDamage;
                    damageText.GetComponent<Text>().text = damage.ToString("N0");
                    if (playerDamage.b)
                    {
                        Attack();
                        playerDamage.b = false;
                    }
                }
            }

        }

    }
    private void Attack()
    {
        Text text;
        text = Instantiate(damageText, new Vector3(0, 0, 0), Quaternion.identity);
        text.transform.SetParent(canvas.transform, false);
        text.transform.position = popPosition;
    }
}
