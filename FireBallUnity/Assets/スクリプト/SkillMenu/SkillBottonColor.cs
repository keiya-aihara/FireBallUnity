using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillBottonColor : MonoBehaviour
{
    [Header("ファイヤーウォール")]
    public Button[] fireWallBottonImage;
    public int fireWallLevel;
    private int fireWallTennkaisuuSyou;
    private int fireWallTennkaisuuDai;
    private bool fireWall;
    [Header("ファイヤーコンボ")]
    public Button[] fireChainImage;
    public int fireChainLevel;
    private float fireComboZyousyouritu;
    private bool fireCombo;
    [Header("ウォール増殖数")]
    public Button[] zousyokusuuImage;
    public int zousyokusuuLevel;
    private int saisyouZousyokusuu;
    private int saidaiZousyokusuu;
    private bool zousyokusuuBool;
    [Header("魔力アップ")]
    public Button[] maryokuUpImage;
    public int maryokuUpLevel;
    private int maryokuZyousyouritu;
    private bool maryokuUp;
    [Header("ファイヤーコストダウン")]
    public Button[] fireBallCostDownImage;
    public int fireBallConstDownLevel;
    private int fireBallCostDownRitu;
    private bool fireBallCostDown;
    [Header("多重詠唱")]
    public Button[] tazyuuEisyouButtonImage;
    public int tazyuuEisyouLevel;
    private int saisyouHassyasuu;
    private int saidaiHassyasuu;
    private bool tazyuueisyou;
    [Header("ファイヤースピア")]
    public Button[] fireSpireButtonImage;
    public int fireSpireLevel;
    private int kanntuuKakuritu;
    private int kanntuuGennsuiritu;
    private bool fireSpire;
    [Header("ラピットファイヤー")]
    public Button[] rapidFireButtonImage;
    public int rapidFireLevel;
    private int rapidKakuritu;
    private int rapidGennsuiritu;
    private bool rapidFire;
    [Header("ファイヤーグラビティ")]
    public Button[] fireGravityButtonImage;
    public int fireGravityLevel;
    private int zyuuryouBairitu;
    private bool fireGravity;
    [Header("ファイヤーボム")]
    public Button[] fireBomButtonImage;
    public int fireBomLevel;
    private int bakuhatuKakuritu;
    private float bakuhatuGennsuiBairitu;
    private bool fireBom;
    [Header("ウォールコンボ")]
    public Button wallChainButtonImage;
    public int wallChainLevel;
    private bool wallcaine;
    [Header("詠唱短縮")]
    public Button eisyouTannsyukuButtonImage;
    public int eisyouTannsyukuLevel;
    private int eisyouZikannBairitu;
    private bool eisyouTannsyuku;
    [Header("無詠唱")]
    public Button mueisyouButtonImage;
    public int mueisyouLevel;
    private int eisyouZikannBairitu2;
    private bool mueisyou;
    [Header("ボタンCoror")]
    public Color kiiro;
    public Color haiiro;
    public Color siro;

    public int syouhiSp;
    public GameObject skillSyutokuPanel;
    public Text skillMeiText;
    public Text skillSetumeiText;
    public Text skillKoukaText;
    public Text skillSyutokuText;
    public bool syutokuzumiSkill;
    public GameObject syoziSPgatarimasennButton;
    public GameObject syutokuzumiButton;
    private PlayerStatusDataBase playerStatusDataBase;
    public Text syoziSp;
    void Start()
    {
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
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
        SyoziSPText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void SyoziSPText()
    {
        syoziSp.text = "SP : " + playerStatusDataBase.syoziSp;
    }
    public void FireWallBottonColor()
    {
        fireWallLevel = playerStatusDataBase.firewallLv;
        for (int a = 0; a <= fireWallLevel - 1; a++)
        {
            fireWallBottonImage[a].image.color = kiiro;
        }
        for (int b = fireWallLevel + 1; b <= 4; b++)
        {
            fireWallBottonImage[b].image.color = haiiro;
        }
        if (fireWallLevel <= 4)
        {
            fireWallBottonImage[fireWallLevel].image.color = siro;
        }
    }
    public void FireChainBottonColor()
    {
        fireChainLevel = playerStatusDataBase.fireComboLv;
        for (int a = 0; a <= fireChainLevel - 1; a++)
        {
            fireChainImage[a].image.color = kiiro;
        }
        for (int b = fireChainLevel + 1; b <= 4; b++)
        {
            fireChainImage[b].image.color = haiiro;
        }
        if (fireChainLevel <= 4)
        {
            fireChainImage[fireChainLevel].image.color = siro;
        }
    }
    public void ZousyokusuuBottonColor()
    {
        zousyokusuuLevel = playerStatusDataBase.zousyokusuuLv;
        if (zousyokusuuLevel == 0)
        {
            if (fireWallLevel == 0 || fireChainLevel == 0)
            {
                for (int a = 0; a <= 4; a++)
                {
                    zousyokusuuImage[a].image.color = haiiro;
                }
            }
            else
            {
                for (int b = 1; b <= 4; b++)
                {
                    zousyokusuuImage[b].image.color = haiiro;
                }
                zousyokusuuImage[0].image.color = siro;
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
            if (zousyokusuuLevel == 4)
            {
                if (fireChainLevel == 5)
                {
                    zousyokusuuImage[4].image.color = siro;
                }
                else
                {
                    zousyokusuuImage[4].image.color = haiiro;
                }
            }
            else if (zousyokusuuLevel <= 3)
            {
                zousyokusuuImage[zousyokusuuLevel].image.color = siro;
            }
        }
    }
    public void MaryokuUpButtonColor()
    {
        maryokuUpLevel = playerStatusDataBase.maryokuUpLv;
        for (int a = 0; a <= maryokuUpLevel - 1; a++)
        {
            maryokuUpImage[a].image.color = kiiro;
        }
        for (int b = maryokuUpLevel + 1; b <= 12; b++)
        {
            maryokuUpImage[b].image.color = haiiro;
        }
        if (maryokuUpLevel <= 12)
        {
            maryokuUpImage[maryokuUpLevel].image.color = siro;
        }
    }
    public void FireBallCostDownButtonColor()
    {
        fireBallConstDownLevel = playerStatusDataBase.fbCostDownLv;
        for (int a = 0; a <= fireBallConstDownLevel - 1; a++)
        {
            fireBallCostDownImage[a].image.color = kiiro;
        }
        for (int b = fireBallConstDownLevel + 1; b <= 12; b++)
        {
            fireBallCostDownImage[b].image.color = haiiro;
        }
        if (fireBallConstDownLevel <= 12)
        {
            fireBallCostDownImage[fireBallConstDownLevel].image.color = siro;
        }
    }
    public void FireSpireButtonColor()
    {
        fireSpireLevel = playerStatusDataBase.fireSpireLv;
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
                fireSpireButtonImage[0].image.color = siro;
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
            if (fireSpireLevel <= 4)
            {
                fireSpireButtonImage[fireSpireLevel].image.color = siro;
            }
        }
    }
    public void RapidFireButtonColor()
    {
        rapidFireLevel = playerStatusDataBase.rapidGireLv;
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
                rapidFireButtonImage[0].image.color = siro;
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
            if (rapidFireLevel <= 4)
            {
                rapidFireButtonImage[rapidFireLevel].image.color = siro;
            }
        }
    }
    public void FireGravityButtonColor()
    {
        fireGravityLevel = playerStatusDataBase.fireGrabityLv;
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
                    fireGravityButtonImage[0].image.color = siro;

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
            if (fireGravityLevel <= 4)
            {
                fireGravityButtonImage[fireGravityLevel].image.color = siro;
            }
        }
    }
    public void FireBomButtonColor()
    {
        fireBomLevel = playerStatusDataBase.fireBomLv;
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
                fireBomButtonImage[0].image.color = siro;
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
            if (fireBomLevel <= 4)
            {
                fireBomButtonImage[fireBomLevel].image.color = siro;
            }
        }
    }
    public void WallChainButtonColor()
    {
        wallChainLevel = playerStatusDataBase.wallChainLv;
        if (wallChainLevel == 0)
        {
            if (fireWallLevel <= 4 || zousyokusuuLevel <= 3)
            {
                wallChainButtonImage.image.color = haiiro;
            }
            else
            {
                wallChainButtonImage.image.color = siro;
            }
        }
        else
        {
            wallChainButtonImage.image.color = kiiro;
        }
    }
    public void TazyuueisyouButtonColor()
    {
        tazyuuEisyouLevel = playerStatusDataBase.tazyuuEisyouLv;
        if (tazyuuEisyouLevel == 0)
        {
            if (maryokuUpLevel == 0 || fireBallConstDownLevel == 0)
            {
                for (int a = 0; a <= 1; a++)
                {
                    tazyuuEisyouButtonImage[a].image.color = haiiro;
                }
            }
            else
            {
                tazyuuEisyouButtonImage[1].image.color = haiiro;
                tazyuuEisyouButtonImage[0].image.color = siro;
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
            if (tazyuuEisyouLevel == 1)
            {
                tazyuuEisyouButtonImage[tazyuuEisyouLevel].image.color = siro;
            }
        }
    }
    public void EisyouTannsyukuButtonColor()
    {
        eisyouTannsyukuLevel = playerStatusDataBase.eisyouTannsyukuLv;
        if (eisyouTannsyukuLevel == 0)
        {
            if (maryokuUpLevel <= 11 || fireBallConstDownLevel <= 11 || tazyuuEisyouLevel <= 1)
            {
                eisyouTannsyukuButtonImage.image.color = haiiro;
            }
            else
            {
                eisyouTannsyukuButtonImage.image.color = siro;
            }
        }
        else
        {
            eisyouTannsyukuButtonImage.image.color = kiiro;
        }
    }
    public void MueisyouButtonColor()
    {
        mueisyouLevel = playerStatusDataBase.mueisyouLv;
        if (mueisyouLevel == 0)
        {
            if (eisyouTannsyukuLevel == 0)
            {
                mueisyouButtonImage.image.color = haiiro;
            }
            else
            {
                mueisyouButtonImage.image.color = siro;
            }
        }
        else
        {
            mueisyouButtonImage.image.color = kiiro;
        }
    }
    public void SkillButtonDown(int number)
    {
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
        switch (number)
        {
            case 1://ファイヤーウォール
                skillSyutokuPanel.SetActive(true);
                FireWallLvUpText();
                skillMeiText.text = "ファイヤーウォール Lv" + (fireWallLevel + 1).ToString("D");
                skillSetumeiText.text = "戦闘開始時にファイヤウォールを展開する。\nファイヤーウォールを通過したファイヤーボールは増殖する。";
                skillKoukaText.text = "Lv" + (fireWallLevel + 1).ToString("D") + "\n展開数" + fireWallTennkaisuuSyou+"～"+fireWallTennkaisuuDai;
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    fireWall = true;
                }
                break;
            case 2://ファイヤーコンボ
                skillSyutokuPanel.SetActive(true);
                FireComboLvUpText();
                skillMeiText.text = "ファイヤーコンボ Lv" + (fireChainLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールの敵へのヒット数に応じて、近接戦闘時の攻撃力が上昇する。";
                skillKoukaText.text = "Lv" + (fireChainLevel + 1).ToString("D") + "\n上昇率" + fireComboZyousyouritu + "%";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    fireCombo = true;
                }
                break;
            case 3://ウォール増殖数
                skillSyutokuPanel.SetActive(true);
                WallZousyokusuuLvUpText();
                skillMeiText.text = "ウォール増殖数 Lv" + (zousyokusuuLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーウォールの増殖数が上昇する。";
                skillKoukaText.text = "Lv" + (zousyokusuuLevel + 1).ToString("D") + "\n増殖数" + saisyouZousyokusuu + "～" + saidaiZousyokusuu;
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    zousyokusuuBool = true;
                }
                break;
            case 4://魔力アップ
                skillSyutokuPanel.SetActive(true);
                MaryokuUpLvUpText();
                skillMeiText.text = "魔力UP Lv" + (maryokuUpLevel + 1).ToString("D");
                skillSetumeiText.text = "基礎魔力が上昇する。";
                skillKoukaText.text = "Lv" + (maryokuUpLevel + 1).ToString("D") + "\n上昇率" + maryokuZyousyouritu + "%";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    maryokuUp = true;
                }
                break;
            case 5://ファイヤーボールコストダウン
                skillSyutokuPanel.SetActive(true);
                FBCostDownLvText();
                skillMeiText.text = "FB消費MPダウン Lv" + (fireBallConstDownLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールの消費MPが減少する。";
                skillKoukaText.text = "Lv" + (fireBallConstDownLevel + 1).ToString("D") + "\n減少率" + fireBallCostDownRitu + "%";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    fireBallCostDown = true;
                }
                break;
            case 6://多重詠唱
                skillSyutokuPanel.SetActive(true);
                TazyuueisyouLvText();
                skillMeiText.text = "多重詠唱 Lv" + (tazyuuEisyouLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボール発射数が確率で増える。";
                skillKoukaText.text = "Lv" + (tazyuuEisyouLevel + 1).ToString("D") + "\n発射数" + saisyouHassyasuu + "～" + saidaiHassyasuu;
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    tazyuueisyou = true;
                }
                break;
            case 7://ファイヤースピア
                skillSyutokuPanel.SetActive(true);
                FireSpireLvText();
                skillMeiText.text = "ファイヤースピア Lv" + (fireSpireLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールが敵を貫通するようになる。\n貫通確率は敵にヒットするたびに減衰する。";
                skillKoukaText.text = "Lv" + (fireSpireLevel + 1).ToString("D") + "\n貫通確率" + kanntuuKakuritu+"%" + "\nヒット時貫通確率減衰率" + kanntuuGennsuiritu+"%";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    fireSpire = true;
                }
                break;
            case 8://ラピットファイヤー
                skillSyutokuPanel.SetActive(true);
                RapidFireLvText();
                skillMeiText.text = "ラビットファイヤー Lv" + (rapidFireLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールが敵にヒットしたときにバウンドするようになる。\nバウンド確率は敵にヒットするたびに減衰する。";
                skillKoukaText.text = "Lv" + (rapidFireLevel + 1).ToString("D") + "\nバウンド確率" + rapidKakuritu + "%" + "\nヒット時バウンド確率減衰率" + rapidGennsuiritu + "%";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    rapidFire = true;
                }
                break;
            case 9://ファイヤーグラビティ
                skillSyutokuPanel.SetActive(true);
                FireGravityLvText();
                skillMeiText.text = "ファイヤーグラビティ Lv" + (fireGravityLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールの重量が上昇し、弾速が上がる。";
                skillKoukaText.text = "Lv" + (fireGravityLevel + 1).ToString("D") + "\n重量+" + zyuuryouBairitu + "%";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    fireGravity = true;
                }
                break;
            case 10://ファイヤーボム
                skillSyutokuPanel.SetActive(true);
                FireBomLvText();
                skillMeiText.text = "ファイヤーボム Lv" + (fireBomLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールが敵に命中したときに、爆発するようになる。\n爆発確率はヒットするたびに減衰していく。";
                skillKoukaText.text = "Lv" + (fireBomLevel + 1).ToString("D") + "\n爆発確率" + bakuhatuKakuritu + "%" + "\n爆発確率減衰倍率" + bakuhatuGennsuiBairitu + "倍";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    fireBom = true;
                }
                break;
            case 11:
                skillSyutokuPanel.SetActive(true);
                WallChainLvText();
                skillMeiText.text = "ウォールコンボ Lv"+(wallChainLevel+1).ToString("D");
                skillSetumeiText.text = "ファイヤーコンボの効果がファイヤーウォールを通過したときにも発動する。";
                skillKoukaText.text = "";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    wallcaine = true;
                }
                break;
            case 12:
                skillSyutokuPanel.SetActive(true);
                EisyoutannsyukuLvText();
                skillMeiText.text = "詠唱短縮 Lv" + (eisyouTannsyukuLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールの長押し発射時の発射速度が早くなる。";
                skillKoukaText.text = "Lv" + (eisyouTannsyukuLevel + 1).ToString("D") + "\n発射速度2倍";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    eisyouTannsyuku = true;
                }
                break;
            case 13:
                skillSyutokuPanel.SetActive(true);
                MueisyouLvText();
                skillMeiText.text = "無詠唱 Lv" + (mueisyouLevel + 1).ToString("D");
                skillSetumeiText.text = "ファイヤーボールの長押し発射時の発射速度がとても早くなる。";
                skillKoukaText.text = "Lv" + (mueisyouLevel + 1).ToString("D") + "\n発射速度3倍";
                skillSyutokuText.text = "消費SP" + syouhiSp + "\nこのスキルを取得しますか？";
                if (playerStatusDataBase.syoziSp < syouhiSp)
                {
                    syoziSPgatarimasennButton.SetActive(true);
                }
                else
                {
                    mueisyou = true;
                }
                break;
                
        }
    }
    public void HaiButtonDown()
    {
        GameObject.Find("SE").GetComponent<HaiIieButtonSE>().HaiButtonSE();
        if (fireWall)
        {
            fireWallLevel++;
            playerStatusDataBase.firewallLv = fireWallLevel;
            FireWallBottonColor();
            ZousyokusuuBottonColor();
            WallChainButtonColor();
            fireWall = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (fireCombo)
        {
            fireChainLevel++;
            playerStatusDataBase.fireComboLv = fireChainLevel;
            FireChainBottonColor();
            ZousyokusuuBottonColor();
            fireCombo = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (zousyokusuuBool)
        {
            zousyokusuuLevel++;
            playerStatusDataBase.zousyokusuuLv = zousyokusuuLevel;
            ZousyokusuuBottonColor();
            WallChainButtonColor();
            zousyokusuuBool = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (maryokuUp)
        {
            maryokuUpLevel++;
            playerStatusDataBase.maryokuUpLv = maryokuUpLevel;
            MaryokuUpButtonColor();
            TazyuueisyouButtonColor();
            FireSpireButtonColor();
            EisyouTannsyukuButtonColor();
            maryokuUp = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (fireBallCostDown)
        {
            fireBallConstDownLevel++;
            playerStatusDataBase.fbCostDownLv = fireBallConstDownLevel;
            FireBallCostDownButtonColor();
            TazyuueisyouButtonColor();
            RapidFireButtonColor();
            EisyouTannsyukuButtonColor();
            fireBallCostDown = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (tazyuueisyou)
        {
            tazyuuEisyouLevel++;
            playerStatusDataBase.tazyuuEisyouLv = tazyuuEisyouLevel;
            TazyuueisyouButtonColor();
            EisyouTannsyukuButtonColor();
            tazyuueisyou = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (fireSpire)
        {
            fireSpireLevel++;
            playerStatusDataBase.fireSpireLv = fireSpireLevel;
            FireSpireButtonColor();
            FireGravityButtonColor();
            fireSpire = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (rapidFire)
        {
            rapidFireLevel++;
            playerStatusDataBase.rapidGireLv = rapidFireLevel;
            RapidFireButtonColor();
            FireBomButtonColor();
            rapidFire = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (fireGravity)
        {
            fireGravityLevel++;
            playerStatusDataBase.fireGrabityLv = fireGravityLevel;
            FireGravityButtonColor();
            fireGravity = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (fireBom)
        {
            fireBomLevel++;
            playerStatusDataBase.fireBomLv = fireBomLevel;
            FireBomButtonColor();
            fireBom = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (wallcaine)
        {
            wallChainLevel++;
            playerStatusDataBase.wallChainLv = wallChainLevel;
            WallChainButtonColor();
            wallcaine = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (eisyouTannsyuku)
        {
            eisyouTannsyukuLevel++;
            playerStatusDataBase.eisyouTannsyukuLv = eisyouTannsyukuLevel;
            EisyouTannsyukuButtonColor();
            MueisyouButtonColor();
            eisyouTannsyuku = false;
            playerStatusDataBase.syoziSp -= syouhiSp;
            skillSyutokuPanel.SetActive(false);
        }
        else if (mueisyou)
        {
            mueisyouLevel++;
            playerStatusDataBase.mueisyouLv = mueisyouLevel;
            MueisyouButtonColor();
            mueisyou = false;
            playerStatusDataBase.syoziSp -= syouhiSp;

            skillSyutokuPanel.SetActive(false);
        }
        playerStatusDataBase.SkillSave();
        SyoziSPText();
    }
    public void IieButtonDown()
    {
        GameObject.Find("SE").GetComponent<HaiIieButtonSE>().IieButtonSE();
        skillSyutokuPanel.SetActive(false);
        fireWall = false;
        fireCombo = false;
        zousyokusuuBool = false;
        maryokuUp = false;
        fireBallCostDown = false;
        tazyuueisyou = false;
        fireSpire = false;
        rapidFire = false;
        fireGravity = false;
        fireBom = false;
        wallcaine = false;
        eisyouTannsyuku = false;
        mueisyou = false;
    }
    public void FireWallLvUpText()
    {
        if (fireWallLevel == 0)
        {
            fireWallTennkaisuuSyou = 1;
            fireWallTennkaisuuDai = 1;
            syouhiSp = 1;
        }
        else if (fireWallLevel == 1)
        {
            fireWallTennkaisuuSyou = 1;
            fireWallTennkaisuuDai = 2;
            syouhiSp = 2;
        }
        else if (fireWallLevel == 2)
        {
            fireWallTennkaisuuSyou = 2;
            fireWallTennkaisuuDai = 2;
            syouhiSp = 3;
        }
        else if (fireWallLevel == 3)
        {
            fireWallTennkaisuuSyou = 2;
            fireWallTennkaisuuDai = 3;
            syouhiSp = 4;
        }
        else
        {
            fireWallTennkaisuuSyou = 3;
            fireWallTennkaisuuDai = 3;
            syouhiSp = 6;
        }
    }
    public void FireComboLvUpText()
    {
        if (fireChainLevel == 0)
        {
            fireComboZyousyouritu = 0.1f;
            syouhiSp = 1;
        }
        else if (fireChainLevel == 1)
        {
            fireComboZyousyouritu = 0.2f;
            syouhiSp = 2;
        }
        else if (fireChainLevel == 2)
        {
            fireComboZyousyouritu = 0.3f;
            syouhiSp = 3;
        }
        else if (fireChainLevel == 3)
        {
            fireComboZyousyouritu = 0.4f;
            syouhiSp = 4;
        }
        else
        {
            fireComboZyousyouritu = 0.5f;
            syouhiSp = 6;
        }
    }
    public void WallZousyokusuuLvUpText()
    {
        if (zousyokusuuLevel == 0)
        {
            saisyouZousyokusuu = 1;
            saidaiZousyokusuu = 2;
            syouhiSp = 2;
        }
        else if (zousyokusuuLevel == 1)
        {
            saisyouZousyokusuu = 2;
            saidaiZousyokusuu = 3;
            syouhiSp = 4;
        }
        else if (zousyokusuuLevel == 2)
        {
            saisyouZousyokusuu = 3;
            saidaiZousyokusuu = 4;
            syouhiSp = 6;
        }
        else if (zousyokusuuLevel == 3)
        {
            saisyouZousyokusuu = 4;
            saidaiZousyokusuu = 5;
            syouhiSp = 8;
        }
        else if (zousyokusuuLevel == 4)
        {
            saisyouZousyokusuu = 4;
            saidaiZousyokusuu = 6;
            syouhiSp = 10;
        }
    }
    public void MaryokuUpLvUpText()
    {
        if (maryokuUpLevel == 0)
        {
            maryokuZyousyouritu = 15;
            syouhiSp = 1;
        }
        else if (maryokuUpLevel == 1)
        {
            maryokuZyousyouritu = 30;
            syouhiSp = 1;
        }
        else if (maryokuUpLevel == 2)
        {
            maryokuZyousyouritu = 45;
            syouhiSp = 2;
        }
        else if (maryokuUpLevel == 3)
        {
            maryokuZyousyouritu = 60;
            syouhiSp = 2;
        }
        else if (maryokuUpLevel == 4)
        {
            maryokuZyousyouritu = 75;
            syouhiSp = 3;
        }
        else if (maryokuUpLevel == 5)
        {
            maryokuZyousyouritu = 90;
            syouhiSp = 3;
        }
        else if (maryokuUpLevel == 6)
        {
            maryokuZyousyouritu = 105;
            syouhiSp = 4;
        }
        else if (maryokuUpLevel == 7)
        {
            maryokuZyousyouritu = 120;
            syouhiSp = 4;
        }
        else if (maryokuUpLevel == 8)
        {
            maryokuZyousyouritu = 135;
            syouhiSp = 5;
        }
        else if (maryokuUpLevel == 9)
        {
            maryokuZyousyouritu = 150;
            syouhiSp = 5;
        }
        else if (maryokuUpLevel == 10)
        {
            maryokuZyousyouritu = 165;
            syouhiSp = 6;
        }
        else if (maryokuUpLevel == 11)
        {
            maryokuZyousyouritu = 180;
            syouhiSp = 6;
        }
        else if (maryokuUpLevel == 12)
        {
            maryokuZyousyouritu = 200;
            syouhiSp = 8;
        }
    }
    public void FBCostDownLvText()
    {
        if (fireBallConstDownLevel == 0)
        {
            fireBallCostDownRitu = 3;
            syouhiSp = 1;
        }
        else if (fireBallConstDownLevel == 1)
        {
            fireBallCostDownRitu = 6;
            syouhiSp = 1;
        }
        else if (fireBallConstDownLevel == 2)
        {
            fireBallCostDownRitu = 9;
            syouhiSp = 2;
        }
        else if (fireBallConstDownLevel == 3)
        {
            fireBallCostDownRitu = 12;
            syouhiSp = 2;
        }
        else if (fireBallConstDownLevel == 4)
        {
            fireBallCostDownRitu = 15;
            syouhiSp = 3;
        }
        else if (fireBallConstDownLevel == 5)
        {
            fireBallCostDownRitu = 18;
            syouhiSp = 3;
        }
        else if (fireBallConstDownLevel == 6)
        {
            fireBallCostDownRitu = 22;
            syouhiSp = 4;
        }
        else if (fireBallConstDownLevel == 7)
        {
            fireBallCostDownRitu = 26;
            syouhiSp = 4;
        }
        else if (fireBallConstDownLevel == 8)
        {
            fireBallCostDownRitu = 30;
            syouhiSp = 5;
        }
        else if (fireBallConstDownLevel == 9)
        {
            fireBallCostDownRitu = 34;
            syouhiSp = 5;
        }
        else if (fireBallConstDownLevel == 10)
        {
            fireBallCostDownRitu = 39;
            syouhiSp = 6;
        }
        else if (fireBallConstDownLevel == 11)
        {
            fireBallCostDownRitu = 44;
            syouhiSp = 6;
        }
        else if (fireBallConstDownLevel == 12)
        {
            fireBallCostDownRitu = 50;
            syouhiSp = 8;
        }
    }
    public void TazyuueisyouLvText()
    {
        if(tazyuuEisyouLevel==0)
        {
            saisyouHassyasuu = 1;
            saidaiHassyasuu = 2;
            syouhiSp = 4;
        }
        else if(tazyuuEisyouLevel==1)
        {
            saisyouHassyasuu = 1;
            saidaiHassyasuu = 3;
            syouhiSp = 6;
        }
    }
    public void FireSpireLvText()
    {
        if(fireSpireLevel==0)
        {
            kanntuuKakuritu = 100;
            kanntuuGennsuiritu = 50;
            syouhiSp = 2;
        }
        else if(fireSpireLevel==1)
        {
            kanntuuKakuritu = 110;
            kanntuuGennsuiritu = 40;
            syouhiSp = 3;
        }
        else if(fireSpireLevel==2)
        {
            kanntuuKakuritu = 120;
            kanntuuGennsuiritu = 30;
            syouhiSp = 4;
        }
        else if(fireSpireLevel==3)
        {
            kanntuuKakuritu = 130;
            kanntuuGennsuiritu = 25;
            syouhiSp = 5;
        }
        else if(fireSpireLevel==4)
        {
            kanntuuKakuritu = 140;
            kanntuuGennsuiritu = 20;
            syouhiSp = 6;
        }
    }
    public void RapidFireLvText()
    {
        if (rapidFireLevel == 0)
        {
            rapidKakuritu = 100;
            rapidGennsuiritu = 50;
            syouhiSp = 2;
        }
        else if (rapidFireLevel == 1)
        {
            rapidKakuritu = 110;
            rapidGennsuiritu = 40;
            syouhiSp = 3;
        }
        else if (rapidFireLevel == 2)
        {
            rapidKakuritu = 120;
            rapidGennsuiritu = 30;
            syouhiSp = 4;
        }
        else if (rapidFireLevel == 3)
        {
            rapidKakuritu = 130;
            rapidGennsuiritu = 25;
            syouhiSp = 5;
        }
        else if (rapidFireLevel == 4)
        {
            rapidKakuritu = 140;
            rapidGennsuiritu = 20;
            syouhiSp = 7;
        }
    }
    public void FireGravityLvText()
    {
        if(fireGravityLevel==0)
        {
            zyuuryouBairitu = 50;
            syouhiSp = 3;
        }
        else if(fireGravityLevel==1)
        {
            zyuuryouBairitu = 100;
            syouhiSp = 4;
        }
        else if(fireGravityLevel==2)
        {
            zyuuryouBairitu = 160;
            syouhiSp = 5;
        }
        else if(fireGravityLevel==3)
        {
            zyuuryouBairitu = 220;
            syouhiSp = 6;
        }
        else if(fireGravityLevel==4)
        {
            zyuuryouBairitu = 300;
            syouhiSp = 8;
        }
    }
    public void FireBomLvText()
    {
        if(fireBomLevel==0)
        {
            bakuhatuKakuritu = 5;
            bakuhatuGennsuiBairitu = 0.5f;
            syouhiSp = 3;
        }
        else if(fireBomLevel==1)
        {
            bakuhatuKakuritu = 10;
            bakuhatuGennsuiBairitu = 0.6f;
            syouhiSp = 4;
        }
        else if(fireBomLevel==2)
        {
            bakuhatuKakuritu = 15;
            bakuhatuGennsuiBairitu = 0.7f;
            syouhiSp = 5;
        }
        else if(fireBomLevel==3)
        {
            bakuhatuKakuritu = 20;
            bakuhatuGennsuiBairitu = 0.75f;
            syouhiSp = 6;
        }
        else if(fireBomLevel==4)
        {
            bakuhatuKakuritu = 25;
            bakuhatuGennsuiBairitu = 0.8f;
            syouhiSp = 8;
        }
    }
    public void WallChainLvText()
    {
        if(wallChainLevel==0)
        {
            syouhiSp = 10;
        }
    }
    public void EisyoutannsyukuLvText()
    {
        if(eisyouTannsyukuLevel==0)
        {
            eisyouZikannBairitu = 2;
            syouhiSp = 8;
        }
    }
    public void MueisyouLvText()
    {
        if(mueisyouLevel==0)
        {
            eisyouZikannBairitu2 = 3;
            syouhiSp = 10;
        }
    }
}
