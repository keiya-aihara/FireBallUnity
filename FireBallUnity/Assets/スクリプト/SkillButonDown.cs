using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButonDown : MonoBehaviour
{
    [Header("ファイヤーウォール")]
    public int fireWallLv;
    public int fireWallTennkaisuu;
    public int fireWallHannizoukakakuritu;
    [Header("ファイヤーコンボ")]
    public int fireComboLv;
    public int zousyokusuuLv;
    public int wallComboLv;
    public int fireSpireLv;
    public int rapidFireLv;
    public int fireGravityLv;
    public int fireBomLv;
    public int maryokuUpLv;
    public int fireBallCostDownLv;
    public int tazyuueisyouLv;
    public int eisyoutannsyukuLv;
    public int mueisyouLv;

    public int syouhiSp;
    public Text skillMeiText;
    public Text skillSetumeiText;
    public Text skillKoukaText;
    public Text skillSyutokuText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SkillButtonDown(int number)
    {
        switch(number)
        {
            case 1://FireWall
                gameObject.SetActive(true);
                FireWallLvUpText();
                skillMeiText.text = "ファイヤーウォール Lv" + (fireWallLv+1).ToString("D");
                skillSetumeiText.text = "戦闘開始時にファイヤウォールを展開する。\nファイヤーウォールを通過したファイヤーボールは増殖する。\nまた、スキルレベルが上がると確率で範囲が広がる。";
                if (fireWallHannizoukakakuritu == 0) skillKoukaText.text = "Lv" + (fireWallLv + 1).ToString("D")+ "\n展開数" + fireWallTennkaisuu;
                else skillKoukaText.text = "Lv" + (fireWallLv +1).ToString("D")+ "\n展開数" + fireWallTennkaisuu + "\n範囲増加確率" + fireWallHannizoukakakuritu;
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                break;
        }
    }
    public void HaiButtonDown()
    {

    }
    public void FireWallLvUpText()
    {
        if(fireWallLv==0)
        {
            fireWallTennkaisuu = 1;
            fireWallHannizoukakakuritu = 0;
            syouhiSp = 1;
        }
        else if(fireWallLv==1)
        {
            fireWallTennkaisuu = 2;
            fireWallHannizoukakakuritu = 0;
            syouhiSp = 2;
        }
        else if(fireWallLv==2)
        {
            fireWallTennkaisuu = 3;
            fireWallHannizoukakakuritu = 0;
            syouhiSp = 3;
        }
        else if(fireWallLv==3)
        {
            fireWallTennkaisuu = 3;
            fireWallHannizoukakakuritu = 15;
            syouhiSp = 4;
        }
        else
        {
            fireWallTennkaisuu = 3;
            fireWallHannizoukakakuritu = 30;
            syouhiSp = 6;
        }
    }
}
