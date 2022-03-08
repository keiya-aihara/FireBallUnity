using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillBottonColor : MonoBehaviour
{
    [Header("ファイヤーウォール")]
    public Button[] fireWallBottonImage;
    public int fireWallLevel;
    [Header("ファイヤーコンボ")]
    public Button[] fireChainImage;
    public int fireChainLevel;
    [Header("ウォール増殖数")]
    public Button[] zousyokusuuImage;
    public int zousyokusuuLevel;
    [Header("魔力アップ")]
    public Button[] maryokuUpImage;
    public int maryokuUpLevel;
    [Header("ファイヤーコストダウン")]
    public Button[] fireBallCostDownImage;
    public int fireBallConstDownLevel;
    [Header("ファイヤースピア")]
    public Button[] fireSpireButtonImage;
    public int fireSpireLevel;
    [Header("ラピットファイヤー")]
    public Button[] rapidFireButtonImage;
    public int rapidFireLevel;
    [Header("ファイヤーグラビティ")]
    public Button[] fireGravityButtonImage;
    public int fireGravityLevel;
    [Header("ファイヤーボム")]
    public Button[] fireBomButtonImage;
    public int fireBomLevel;
    [Header("ウォールコンボ")]
    public Button wallChainButtonImage;
    public int wallChainLevel;
    [Header("多重詠唱")]
    public Button[] tazyuuEisyouButtonImage;
    public int tazyuuEisyouLevel;
    [Header("詠唱短縮")]
    public Button eisyouTannsyukuButtonImage;
    public int eisyouTannsyukuLevel;
    [Header("無詠唱")]
    public Button mueisyouButtonImage;
    public int mueisyouLevel;
    [Header("ボタンCoror")]
    public Color kiiro;
    public Color haiiro;

    [Header("ファイヤーウォール")]
    public int fireWallTennkaisuu;
    public int fireWallHannizoukakakuritu;
    public bool fireWall;
    [Header("ファイヤーコンボ")]


    public int syouhiSp;
    public GameObject skillSyutokuPanel;
    public Text skillMeiText;
    public Text skillSetumeiText;
    public Text skillKoukaText;
    public Text skillSyutokuText;
    void Start()
    {
        FireWallBottonColor();
        FireChainBottonColor();
        ZousyokusuuBottonColor();
        MaryokuUpButtonColor();
        FireBallCostDownButtonColor();
        FireSpireButtonColor();
        RapidFireButtonColor();
        FireGravityButtonColor();
        FireBomButtonColor();
        WallChainButtonColor();
        TazyuueisyouButtonColor();
        EisyouTannsyukuButtonColor();
        MueisyouButtonColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FireWallBottonColor()
    {
        for (int a = 0; a <= fireWallLevel - 1; a++)
        {
            fireWallBottonImage[a].image.color = kiiro;
        }
        for (int b = fireWallLevel + 1; b <= 4; b++)
        {
            fireWallBottonImage[b].image.color = haiiro;
        }
    }
    public void FireChainBottonColor()
    {
        for (int a = 0; a <= fireChainLevel - 1; a++)
        {
            fireChainImage[a].image.color = kiiro;
        }
        for (int b = fireChainLevel + 1; b <= 4; b++)
        {
            fireChainImage[b].image.color = haiiro;
        }
    }
    public void ZousyokusuuBottonColor()
    {
        if (zousyokusuuLevel == 0)
        {
            if (fireWallLevel == 0 || fireChainLevel == 0)
            {
                for(int a =0; a <= 4; a++)
                {
                    zousyokusuuImage[a].image.color = haiiro;
                }
            }
            else
            {
                for(int b = 1;b<=4;b++)
                {
                    zousyokusuuImage[b].image.color = haiiro;
                }
            }
        }
        else
        {
            for (int a = 0; a <= zousyokusuuLevel - 1; a++)
            {
                zousyokusuuImage[a].image.color = kiiro;
            }
            for (int b = zousyokusuuLevel + 1; b <= 4; b++)
            {
                zousyokusuuImage[b].image.color = haiiro;
            }
        }
    }
    public void MaryokuUpButtonColor()
    {
        for (int a = 0; a <= maryokuUpLevel - 1; a++)
        {
            maryokuUpImage[a].image.color = kiiro;
        }
        for (int b = maryokuUpLevel + 1; b <= 12; b++)
        {
            maryokuUpImage[b].image.color = haiiro;
        }
    }
    public void FireBallCostDownButtonColor()
    {
        for (int a = 0; a <= fireBallConstDownLevel - 1; a++)
        {
            fireBallCostDownImage[a].image.color = kiiro;
        }
        for (int b = fireBallConstDownLevel + 1; b <= 12; b++)
        {
            fireBallCostDownImage[b].image.color = haiiro;
        }
    }
    public void FireSpireButtonColor()
    {
        if (fireSpireLevel == 0)
        {
            if (maryokuUpLevel <= 1)
            {
                for (int a = 0; a <= 4; a++)
                {
                    fireSpireButtonImage[a].image.color = haiiro;
                }
            }
            else
            {
                for (int b = 1; b <= 4; b++)
                {
                    fireSpireButtonImage[b].image.color = haiiro;
                }
            }
        }
        else
        {
            for (int a = 0; a <= fireSpireLevel - 1; a++)
            {
                fireSpireButtonImage[a].image.color = kiiro;
            }
            for (int b = fireSpireLevel + 1; b <= 4; b++)
            {
                fireSpireButtonImage[b].image.color = haiiro;
            }
        }
    }
    public void RapidFireButtonColor()
    {
        if (rapidFireLevel == 0)
        {
            if (fireBallConstDownLevel <= 1)
            {
                for (int a = 0; a <= 4; a++)
                {
                    rapidFireButtonImage[a].image.color = haiiro;
                }
            }
            else
            {
                for (int b = 1; b <= 4; b++)
                {
                    rapidFireButtonImage[b].image.color = haiiro;
                }
            }
        }
        else
        {
            for (int a = 0; a <= rapidFireLevel - 1; a++)
            {
                rapidFireButtonImage[a].image.color = kiiro;
            }
            for (int b = rapidFireLevel + 1; b <= 4; b++)
            {
                rapidFireButtonImage[b].image.color = haiiro;
            }
        }
    }
    public void FireGravityButtonColor()
    {
        if (fireGravityLevel == 0)
        {
            if (fireSpireLevel == 0)
            {
                for (int a = 0; a <= 4; a++)
                {
                    fireGravityButtonImage[a].image.color = haiiro;
                }
            }
            else
            {
                for (int b = 1; b <= 4; b++)
                {
                    fireGravityButtonImage[b].image.color = haiiro;
                }
            }
        }
        else
        {
            for (int a = 0; a <= fireGravityLevel - 1; a++)
            {
                fireGravityButtonImage[a].image.color = kiiro;
            }
            for (int b = fireGravityLevel + 1; b <= 4; b++)
            {
                fireGravityButtonImage[b].image.color = haiiro;
            }
        }
    }
    public void FireBomButtonColor()
    {
        if (fireBomLevel == 0)
        {
            if (rapidFireLevel == 0)
            {
                for (int a = 0; a <= 4; a++)
                {
                    fireBomButtonImage[a].image.color = haiiro;
                }
            }
            else
            {
                for (int b = 1; b <= 4; b++)
                {
                    fireBomButtonImage[b].image.color = haiiro;
                }
            }
        }
        else
        {
            for (int a = 0; a <= fireBomLevel - 1; a++)
            {
                fireBomButtonImage[a].image.color = kiiro;
            }
            for (int b = fireBomLevel + 1; b <= 4; b++)
            {
                fireBomButtonImage[b].image.color = haiiro;
            }
        }
    }
    public void WallChainButtonColor()
    {
        if (wallChainLevel==0)
        {
            if (fireWallLevel <=4 || zousyokusuuLevel <=3)
            {
                wallChainButtonImage.image.color = haiiro;
            }
        }
        else
        {
            wallChainButtonImage.image.color = kiiro;
        }
    }
    public void TazyuueisyouButtonColor()
    {
        if (tazyuuEisyouLevel == 0)
        {
            if (maryokuUpLevel== 0 || fireBallConstDownLevel == 0)
            {
                for (int a = 0; a <= 1; a++)
                {
                    tazyuuEisyouButtonImage[a].image.color = haiiro;
                }
            }
            else
            {
                tazyuuEisyouButtonImage[1].image.color = haiiro;
            }
        }
        else
        {
            for (int a = 0; a <= tazyuuEisyouLevel - 1; a++)
            {
                tazyuuEisyouButtonImage[a].image.color = kiiro;
            }
            for (int b = tazyuuEisyouLevel + 1; b <= 1; b++)
            {
                tazyuuEisyouButtonImage[b].image.color = haiiro;
            }
        }
    }
    public void EisyouTannsyukuButtonColor()
    {
        if (eisyouTannsyukuLevel == 0)
        {
            if (maryokuUpLevel <=11 || fireBallConstDownLevel <= 11 || tazyuuEisyouLevel<=1)
            {
                eisyouTannsyukuButtonImage.image.color = haiiro;
            }
        }
        else
        {
                eisyouTannsyukuButtonImage.image.color = kiiro;
        }
    }
    public void MueisyouButtonColor()
    {
        if (mueisyouLevel == 0)
        {
            if (eisyouTannsyukuLevel==0)
            {
                mueisyouButtonImage.image.color = haiiro;
            }
        }
        else
        {
            eisyouTannsyukuButtonImage.image.color = kiiro;
        }
    }
    public void SkillButtonDown(int number)
    {
        switch (number)
        {
            case 1://FireWall
                skillSyutokuPanel.SetActive(true);
                FireWallLvUpText();
                skillMeiText.text = "ファイヤーウォール Lv" + (fireWallLevel + 1).ToString("D");
                skillSetumeiText.text = "戦闘開始時にファイヤウォールを展開する。\nファイヤーウォールを通過したファイヤーボールは増殖する。\nまた、スキルレベルが上がると確率で範囲が広がる。";
                if (fireWallHannizoukakakuritu == 0) skillKoukaText.text = "Lv" + (fireWallLevel + 1).ToString("D") + "\n展開数" + fireWallTennkaisuu;
                else skillKoukaText.text = "Lv" + (fireWallLevel + 1).ToString("D") + "\n展開数" + fireWallTennkaisuu + "\n範囲増加確率" + fireWallHannizoukakakuritu;
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                fireWall = true;
                break;
        }
    }
    public void HaiButtonDown()
    {
        if(fireWall)
        {
            fireWallLevel++;
            FireWallBottonColor();
            skillSyutokuPanel.SetActive(false);
        }
    }
    public void FireWallLvUpText()
    {
        if (fireWallLevel == 0)
        {
            fireWallTennkaisuu = 1;
            fireWallHannizoukakakuritu = 0;
            syouhiSp = 1;
        }
        else if (fireWallLevel == 1)
        {
            fireWallTennkaisuu = 2;
            fireWallHannizoukakakuritu = 0;
            syouhiSp = 2;
        }
        else if (fireWallLevel == 2)
        {
            fireWallTennkaisuu = 3;
            fireWallHannizoukakakuritu = 0;
            syouhiSp = 3;
        }
        else if (fireWallLevel == 3)
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
