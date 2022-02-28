using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTaxtCanvas : MonoBehaviour
{
    public Text damageText; //�_�[���[�W�e�L�X�g���i�[
    public Text missText;
    public int damage;
    public GameObject enemy; //�G�L�������i�[
    private EnemyBase enemyBase;
    private GameObject canvas;//�e�ɂ���L�����o�X���i�[


    // Start is called before the first frame update
    void Start()
    {
        enemyBase = enemy.GetComponent<EnemyBase>();
        //�e�ɂ���L�����o�X���擾
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
                damageText.GetComponent<Text>().text = "��S�I�I\r\n" + damage.ToString("N0");
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