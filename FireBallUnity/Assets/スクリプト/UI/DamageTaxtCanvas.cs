using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTaxtCanvas : MonoBehaviour
{
    public Text damageText; //ダーメージテキストを格納
    public Text missText;
    public int damage;
    public EnemyBase enemyBase;
    private GameObject canvas;//親にするキャンバスを格納


    // Start is called before the first frame update
    void Start()
    {
        //親にするキャンバスを取得
        canvas = GameObject.Find("MainCameraCanvas");
        enemyBase.damageTaxtCanvas = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyBase.damageTextIkkaiBool)
        {
            DamageTextPopUp();
        }
        if(enemyBase.missTextBool)
        {
            Instantiate(missText, enemyBase.damagePosition, transform.rotation,canvas.transform);
            enemyBase.missTextBool = false;
        }
    }
    public void DamageTextPopUp()
    {
        if (enemyBase.kaisinnBool)
        {
            damage = enemyBase.enemyDamage;
            damageText.GetComponent<Text>().text = "会心！！\r\n" + damage.ToString("N0");
            Instantiate(damageText, enemyBase.damagePosition, transform.rotation, canvas.transform);
            enemyBase.damageTextIkkaiBool = false;
            enemyBase.kaisinnBool = false;
        }
        else
        {
            damage = enemyBase.enemyDamage;
            damageText.GetComponent<Text>().text = damage.ToString("N0");
            Instantiate(damageText, enemyBase.damagePosition, transform.rotation, canvas.transform);
            enemyBase.damageTextIkkaiBool = false;
        }
    }

}
