using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboCounter : MonoBehaviour
{
    public int comboCount;
    public int fireWallComboCount;
    public Text comboText;
    public float comboBairitu;
    public GameObject player;
    public PlayerStatus playerStatus;
    public bool comboCountChangeBairitu;
    void Start()
    {
        if(DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>().fireComboLv==0)
        {
            gameObject.SetActive(false);
        }
        comboCountChangeBairitu = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (comboCountChangeBairitu)
        {
            
            comboText.text = comboCount +fireWallComboCount+ "\nコンボ!!";
            if (player.transform.position.y <= -5.8f)
            {
                if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>().wallChainLv == 0)
                {
                    comboBairitu = comboCount * playerStatus.comboBairitu;
                }
                else comboBairitu = (comboCount + fireWallComboCount) * playerStatus.comboBairitu;

                comboText.text = "攻撃力\n" + comboBairitu + "%UP";
                Debug.Log(Mathf.CeilToInt(playerStatus.kougekiryoku * (1+(comboBairitu/100.00f))));
                playerStatus.kougekiryoku = Mathf.CeilToInt(playerStatus.kougekiryoku * (1 + (comboBairitu / 100.00f)));
                comboCountChangeBairitu = false;
            }
            else if (player.transform.position.y <= 5.8f)
            {
                gameObject.transform.localPosition = new Vector2(6.89f, 0);
            }
            
        }
    }
}
