using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatuMenuSkill : MonoBehaviour
{
    public bool content;

    private GameObject dataBasaManager;
    private PlayerStatusDataBase playerStatusDataBase;

    private SoubiSkillDatabase soubiSkillDatabase;
    private SoubiSkillDataList.SoubiSkillData soubiSkillData;

    public GameObject activeSkill;
    public GameObject pasivSkill;
    public GameObject skillSetumeiPanel;
    public Text skillMeiText;
    public Text skillSetumeiText;
    public Text skillKoukaText;

    [Space(1)]
    public Text fireSpireText;
    public Text rapidFireText;
    public Text fireBomText;

    public Text rennzokuGiriLv1;
    public Text hokyuuLv1;
    public Text kyouGiriLv1;
    public Text makennnoTikaraHiLv1;
    public Text kyougiriLv2;
    public Text hokyuuLv2;
    //▼アクティブスキルが増えるたびに追加していく

    [Space(1)]
    public Text fireWallText;
    public Text zousyokusuuText;
    public Text fireComboText;
    public Text wallComboText;
    public Text tazyuuEisyouText;
    public Text fireGravityText;
    public Text eisyouTannsyukuText;
    public Text mueisyouText;
    public Text maryokuUpText;
    public Text fbCostDownText;

    public Text saikutuLv1;
    public Text damageKeigennLv1;
    public Text kyuusyuuLv1;
    public Text asidBallLv1;
    public Text asidSrushLv1;
    public Text sekikaHanngekiLv1;
    public Text damageKeigennLv2;
    public Text saikutuLv2;
    public Text maryokuBousouLv1;
    public Text kyuusyuuLv2;
    //▼パッシブスキルが増えるたびに追加していく


    //低レベルスキル省略用object
    private GameObject damageKeigennLv1Destroy;
    private GameObject kyougiriLv1Destroy;
    private GameObject saikutuLv1Destroy;
    private GameObject hokyuuLv1Destroy;
    void Start()
    {
        dataBasaManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatusDataBase = dataBasaManager.GetComponent<PlayerStatusDataBase>();
        soubiSkillDatabase = dataBasaManager.GetComponent<SoubiSkillDatabase>();

        SkillUpdata();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SkillUpdata()
    {
        Debug.Log("スキルアップデート発動");
        foreach (Transform n in gameObject.transform)
        {
            GameObject.Destroy(n.gameObject);
        }

        if (content)
        {
            Instantiate(activeSkill, transform.position, transform.rotation, transform);
            //▼基礎アクティブスキル
            if (playerStatusDataBase.fireSpireLv >= 1)
            {
                if (playerStatusDataBase.fireSpireLv <= 4) fireSpireText.text = "ファイヤースピア Lv" + playerStatusDataBase.fireSpireLv;
                else fireSpireText.text = "ファイヤースピア Lv極";
                Instantiate(fireSpireText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.rapidGireLv >= 1)
            {
                if (playerStatusDataBase.rapidGireLv <= 4) rapidFireText.text = "ラピッドファイヤー Lv" + playerStatusDataBase.rapidGireLv;
                else rapidFireText.text = "ラピッドファイヤー Lv極";
                Instantiate(rapidFireText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fireBomLv >= 1)
            {
                if (playerStatusDataBase.fireBomLv <= 4) fireBomText.text = "ファイヤーボム Lv" + playerStatusDataBase.fireBomLv;
                else fireBomText.text = "ファイヤーボム Lv極";
                Instantiate(fireBomText.gameObject, transform.position, transform.rotation, transform);
            }
            //▼装備アクティブスキルスキル
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 1)//連続斬りLv.1
                {
                    Instantiate(rennzokuGiriLv1.gameObject, transform.position, transform.rotation, transform);
                }

                if (soubiSkillDatabase.skillNumber[a] == 2)//補給Lv.1
                {
                    hokyuuLv1Destroy = Instantiate(hokyuuLv1.gameObject, transform.position, transform.rotation, transform);
                }

                if (soubiSkillDatabase.skillNumber[a] == 6)//強斬りLv.1
                {
                    kyougiriLv1Destroy = Instantiate(kyouGiriLv1.gameObject, transform.position, transform.rotation, transform);
                }

                if (soubiSkillDatabase.skillNumber[a] == 9)//魔剣の力[火]Lv.1
                {
                    Instantiate(makennnoTikaraHiLv1.gameObject, transform.position, transform.rotation, transform);
                }
                if (soubiSkillDatabase.skillNumber[a] == 12)//強斬りLv.2
                {
                    Instantiate(kyougiriLv2.gameObject, transform.position, transform.rotation, transform);
                    if(kyougiriLv1Destroy!=null)
                    {
                        Destroy(kyougiriLv1Destroy);
                    }
                }
                if (soubiSkillDatabase.skillNumber[a] == 16)//補給Lv.2
                {
                    Instantiate(hokyuuLv2.gameObject, transform.position, transform.rotation, transform);
                    if (hokyuuLv1Destroy != null)
                    {
                        Destroy(hokyuuLv1Destroy);
                    }
                }
            }
            //▼アクティブスキルが増えたら追加していく。

            Instantiate(pasivSkill, transform.position, transform.rotation, transform);

            //▼基礎パッシブスキル
            if (playerStatusDataBase.firewallLv >= 1)
            {
                if (playerStatusDataBase.firewallLv <= 4) fireWallText.text = "ファイヤーウォール Lv" + playerStatusDataBase.firewallLv;
                else fireWallText.text = "ファイヤーウォール Lv極";
                Instantiate(fireWallText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.zousyokusuuLv >= 1)
            {
                if (playerStatusDataBase.zousyokusuuLv <= 4) zousyokusuuText.text = "増殖数 Lv" + playerStatusDataBase.zousyokusuuLv;
                else zousyokusuuText.text = "増殖数 Lv極";
                Instantiate(zousyokusuuText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fireComboLv >= 1)
            {
                if (playerStatusDataBase.fireComboLv <= 4) fireComboText.text = "ファイヤーコンボ Lv" + playerStatusDataBase.fireComboLv;
                else fireComboText.text = "ファイヤーコンボ Lv極";
                Instantiate(fireComboText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.wallChainLv >= 1)
            {
                wallComboText.text = "ウォールコンボ Lv極";
                Instantiate(wallComboText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.tazyuuEisyouLv >= 1)
            {
                if (playerStatusDataBase.tazyuuEisyouLv <= 1) tazyuuEisyouText.text = "多重詠唱 Lv" + playerStatusDataBase.tazyuuEisyouLv;
                else tazyuuEisyouText.text = "多重詠唱 Lv極";
                Instantiate(tazyuuEisyouText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fireGrabityLv >= 1)
            {
                if (playerStatusDataBase.fireGrabityLv <= 4) fireGravityText.text = "ファイヤーグラビティ Lv" + playerStatusDataBase.fireGrabityLv;
                else fireGravityText.text = "ファイヤーグラビティ Lv極";
                Instantiate(fireGravityText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.eisyouTannsyukuLv >= 1)
            {
                eisyouTannsyukuText.text = "詠唱短縮 Lv極";
                Instantiate(eisyouTannsyukuText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.mueisyouLv >= 1)
            {
                mueisyouText.text = "無詠唱 Lv極";
                Instantiate(mueisyouText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.maryokuUpLv >= 1)
            {
                if (playerStatusDataBase.maryokuUpLv <= 12) maryokuUpText.text = "魔力アップ Lv" + playerStatusDataBase.maryokuUpLv;
                else maryokuUpText.text = "魔力アップ Lv極";
                Instantiate(maryokuUpText.gameObject, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fbCostDownLv >= 1)
            {
                if (playerStatusDataBase.fbCostDownLv <= 12) fbCostDownText.text = "FBコストダウン Lv" + playerStatusDataBase.fbCostDownLv;
                else fbCostDownText.text = "FBコストダウン Lv極";
                Instantiate(fbCostDownText.gameObject, transform.position, transform.rotation, transform);
            }
            //▼装備パッシブスキル

            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 3)//採掘Lv.1
                {
                    saikutuLv1Destroy = Instantiate(saikutuLv1.gameObject, transform.position, transform.rotation, transform);
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 4)//ダメージ軽減Lv.1
                {
                    damageKeigennLv1Destroy = Instantiate(damageKeigennLv1.gameObject, transform.position, transform.rotation, transform);
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 5)//吸収Lv.1
                {
                    Instantiate(kyuusyuuLv1.gameObject, transform.position, transform.rotation, transform);
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 7)//アシッドボールLv.1
                {
                    Instantiate(asidBallLv1.gameObject, transform.position, transform.rotation, transform);
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 8)//アシッドスラッシュ
                {
                    Instantiate(asidSrushLv1.gameObject, transform.position, transform.rotation, transform);
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 10)//石化反撃Lv.1
                {
                    Instantiate(sekikaHanngekiLv1.gameObject, transform.position, transform.rotation, transform);
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 11)//ダメージ軽減Lv.2
                {
                    Instantiate(damageKeigennLv2.gameObject, transform.position, transform.rotation, transform);

                    if (damageKeigennLv1Destroy != null)
                    {
                        Destroy(damageKeigennLv1Destroy);
                    }
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 13)//採掘Lv.2
                {
                    Instantiate(saikutuLv2.gameObject, transform.position, transform.rotation, transform);

                    if (saikutuLv1Destroy != null)
                    {
                        Destroy(saikutuLv1Destroy);
                    }
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 14)//魔力暴走Lv.1
                {
                    Instantiate(maryokuBousouLv1.gameObject, transform.position, transform.rotation, transform);
                }
            }
            for (int a = 0; a < soubiSkillDatabase.skillNumber.Length; a++)
            {
                if (soubiSkillDatabase.skillNumber[a] == 15)//吸収Lv.2
                {
                    Instantiate(kyuusyuuLv2.gameObject, transform.position, transform.rotation, transform);
                }
            }
            //▼パッシブスキルが追加になるたびに増やす

            //低レベルスキルの説明を省く↓

        }
    }
    public void SkillSetumei(int skillNumber)
    {
        skillSetumeiPanel.SetActive(true);
        switch (skillNumber)
        {
            case 1:
                if (playerStatusDataBase.fireSpireLv <= 4) skillMeiText.text = "ファイヤースピア Lv" + playerStatusDataBase.fireSpireLv;
                else skillMeiText.text = "ファイヤースピア Lv極";
                skillSetumeiText.text = "ファイヤーボールが敵を貫通するようになる。\n貫通確率は敵にヒットするたびに減衰する。";
                playerStatusDataBase.FireSpireLvText();
                skillKoukaText.text = "貫通確率" + playerStatusDataBase.kanntuuKakuritu + "%" + "\nヒット時貫通確率減衰率" + playerStatusDataBase.kanntuuGennsuiritu + "%";
                break;
            case 2:
                if (playerStatusDataBase.rapidGireLv <= 4) skillMeiText.text = "ラビットファイヤー Lv" + playerStatusDataBase.rapidGireLv;
                else skillMeiText.text = "ラビットファイヤー Lv極";
                skillSetumeiText.text = "ファイヤーボールが敵にヒットしたときにバウンドするようになる。\nバウンド確率は敵にヒットするたびに減衰する。";
                playerStatusDataBase.RapidFireLvText();
                skillKoukaText.text = "バウンド確率" + playerStatusDataBase.rapidKakuritu + "%" + "\nヒット時バウンド確率減衰率" + playerStatusDataBase.rapidGennsuiritu + "%";
                break;
            case 3:
                if (playerStatusDataBase.fireBomLv <= 4) skillMeiText.text = "ファイヤーボム Lv" + playerStatusDataBase.fireBomLv;
                else skillMeiText.text = "ファイヤーボム Lv極";
                skillSetumeiText.text = "ファイヤーボールが敵に命中したときに、爆発するようになる。\n爆発確率はヒットするたびに減衰していく。";
                playerStatusDataBase.FireBomLvText();
                skillKoukaText.text = "爆発確率" + playerStatusDataBase.bakuhatuKakuritu + "%" + "\n爆発確率減衰倍率" + playerStatusDataBase.bakuhatuGennsuiBairitu + "倍";
                break;
            case 4:
                if (playerStatusDataBase.firewallLv <= 4) skillMeiText.text = "ファイヤーウォール Lv" + playerStatusDataBase.firewallLv;
                else skillMeiText.text = "ファイヤーウォール Lv極";
                skillSetumeiText.text = "戦闘開始時にファイヤウォールを展開する。\nファイヤーウォールを通過したファイヤーボールは増殖する。";
                playerStatusDataBase.FireWallLvUpText();
                skillKoukaText.text = "展開数" + playerStatusDataBase.fireWallTennkaisuuSyou + "～" + playerStatusDataBase.fireWallTennkaisuuDai;

                break;
            case 5:
                if (playerStatusDataBase.zousyokusuuLv <= 4) skillMeiText.text = "ウォール増殖数 Lv" + playerStatusDataBase.zousyokusuuLv;
                else skillMeiText.text = "ウォール増殖数 Lv極";
                skillSetumeiText.text = "ファイヤーウォールの増殖数が上昇する。";
                playerStatusDataBase.WallZousyokusuuLvUpText();
                skillKoukaText.text = "増殖数" + playerStatusDataBase.saisyouZousyokusuu + "～" + playerStatusDataBase.saidaiZousyokusuu;
                break;
            case 6:
                if (playerStatusDataBase.fireComboLv <= 4) skillMeiText.text = "ファイヤーコンボ Lv" + playerStatusDataBase.fireComboLv;
                else skillMeiText.text = "ファイヤーコンボ Lv極";
                skillSetumeiText.text = "ファイヤーボールの敵へのヒット数に応じて、近接戦闘時の攻撃力が上昇する。";
                playerStatusDataBase.FireComboLvUpText();
                skillKoukaText.text = "上昇率" + playerStatusDataBase.fireComboZyousyouritu + "%";
                break;
            case 7:
                skillMeiText.text = "ウォールコンボ Lv極";
                skillSetumeiText.text = "ファイヤーコンボの効果がファイヤーウォールを通過したときにも発動する。";
                skillKoukaText.text = "";
                break;
            case 8:
                if (playerStatusDataBase.tazyuuEisyouLv <= 1) skillMeiText.text = "多重詠唱 Lv" + playerStatusDataBase.tazyuuEisyouLv;
                else skillMeiText.text = "多重詠唱 Lv極";
                skillSetumeiText.text = "ファイヤーボール発射数が確率で増える。";
                playerStatusDataBase.TazyuueisyouLvText();
                skillKoukaText.text = "発射数" + playerStatusDataBase.tazyuuEisyouSaisyouhassyasuu + "～" + playerStatusDataBase.tazyuuEisyouSaidaihassyasuu;
                break;
            case 9:
                if (playerStatusDataBase.fireGrabityLv <= 4) skillMeiText.text = "ファイヤーグラビティ Lv" + playerStatusDataBase.fireGrabityLv;
                else skillMeiText.text = "ファイヤーグラビティ Lv極";
                skillSetumeiText.text = "ファイヤーボールの重量が上昇し、弾速が上がる。";
                playerStatusDataBase.FireGravityLvText();
                skillKoukaText.text = "重量+" + playerStatusDataBase.zyuuryouBairitu + "%";
                break;
            case 10:
                skillMeiText.text = "詠唱短縮 Lv極";
                skillSetumeiText.text = "ファイヤーボールの長押し発射時の発射速度が早くなる。";
                skillKoukaText.text = "発射速度2倍";
                break;
            case 11:
                skillMeiText.text = "無詠唱 Lv極";
                skillSetumeiText.text = "ファイヤーボールの長押し発射時の発射速度がとても早くなる。";
                skillKoukaText.text = "発射速度3倍";
                break;
            case 12:
                if (playerStatusDataBase.maryokuUpLv <= 12) skillMeiText.text = "魔力UP Lv" + playerStatusDataBase.maryokuUpLv;
                else skillMeiText.text = "魔力UP 極";
                skillSetumeiText.text = "基礎魔力が上昇する。";
                playerStatusDataBase.MaryokuUpLvUpText();
                skillKoukaText.text = "上昇率" + playerStatusDataBase.skillMaryokuZyousyouritu + "%";
                break;
            case 13:
                if (playerStatusDataBase.fbCostDownLv <= 12) skillMeiText.text = "FB消費MPダウン Lv" + playerStatusDataBase.fbCostDownLv;
                else skillMeiText.text = "FB消費MPダウン Lv極";
                skillSetumeiText.text = "ファイヤーボールの消費MPが減少する。";
                playerStatusDataBase.FBCostDownLvText();
                skillKoukaText.text = "減少率" + playerStatusDataBase.skillFireBallCostDownRitu + "%";
                break;

        }
    }
    public void SoubiSkillSetumei(int soubiSkillNumber)
    {
        skillSetumeiPanel.SetActive(true);
        soubiSkillData = soubiSkillDatabase.GetSoubiSkillData(soubiSkillNumber);
        switch (soubiSkillNumber)
        {
            case 1:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 2:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 3:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 4:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 5:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 6:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "威力:" + soubiSkillData.iryoku.ToString();
                break;
            case 7:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 8:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 9:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 10:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 11:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 12:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "威力:" + soubiSkillData.iryoku.ToString();
                break;
            case 13:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 14:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 15:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "";//威力なしの場合は空白
                break;
            case 16:
                skillMeiText.text = soubiSkillData.skillName;
                skillSetumeiText.text = soubiSkillData.skillSetumei;
                skillKoukaText.text = "威力:" + soubiSkillData.iryoku.ToString();
                break;
        }
    }

}
