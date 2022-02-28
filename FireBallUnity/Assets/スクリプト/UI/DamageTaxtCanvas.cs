using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTaxtCanvas : MonoBehaviour
{
    public Text damageText; //ダーメージテキストを格納
    public Text missText;
    public int damage;
    public GameObject enemy; //敵キャラを格納
    private EnemyBase enemyBase;
    private GameObject canvas;//親にするキャンバスを格納


    // Start is called before the first frame update
    void Start()
    {
        enemyBase = enemy.GetComponent<EnemyBase>();
        //親にするキャンバスを取得
        canvas = GameObject.Find("MainCameraCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        

        if (enemyBase.e)
        {
            if (enemyBase.l)
            {
                damage = enemyBase.enemyDamage;
                damageText.GetComponent<Text>().text = "会心！！\r\n" + damage.ToString("N0");
                Instantiate(damageText, enemyBase.damagePosition, transform.rotation, canvas.transform);
                enemyBase.e = false;
                enemyBase.l = false;
            }
            else
            {
                damage = enemyBase.enemyDamage;
                damageText.GetComponent<Text>().text = damage.ToString("N0");
                Instantiate(damageText, enemyBase.damagePosition, transform.rotation, canvas.transform);
                enemyBase.e = false;
            }
        }
        if(enemyBase.k)
        {
            Instantiate(missText, enemyBase.damagePosition, transform.rotation,canvas.transform);
            enemyBase.k = false;
        }
    }
}