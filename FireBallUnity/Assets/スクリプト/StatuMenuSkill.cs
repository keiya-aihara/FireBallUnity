using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatuMenuSkill : MonoBehaviour
{
    public bool content;
    private GameObject dataBasaManager;
    private PlayerStatusDataBase playerStatusDataBase;

    public GameObject activeSkill;
    public GameObject pasivSkill;
    public GameObject skillSetumeiPanel;
    public Text skillMeiText;
    public Text skillSetumeiText;
    public Text skillKoukaText;

    [Space(1)]//アクティブスキルが増えるたびに追加していく
    public GameObject fireSpire;
    public GameObject rapidFire;
    public GameObject fireBom;

    [Space(1)]//パッシブスキルが増えるたびに追加していく
    public GameObject fireWall;
    public GameObject zousyokusuu;
    public GameObject fireCombo;
    public GameObject wallCombo;
    public GameObject tazyuuEisyou;
    public GameObject fireGravity;
    public GameObject eisyouTannsyuku;
    public GameObject mueisyou;
    public GameObject maryokuUp;
    public GameObject fbCostDown;

    [Space(1)]
    public Text fireSpireText;
    public Text rapidFireText;
    public Text fireBomText;
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
    [Space(1)]
    public SkillButtonDown fireSpireNumber;
    public SkillButtonDown rapidFireNumber;
    public SkillButtonDown fireBomTextNumber;
    public SkillButtonDown fireWallNumber;
    public SkillButtonDown zousyokusuuNumber;
    public SkillButtonDown fireComboNumber;
    public SkillButtonDown wallComboNumber;
    public SkillButtonDown tazyuuEisyouNumber;
    public SkillButtonDown fireGravityNumber;
    public SkillButtonDown eisyouTannsyukuNumber;
    public SkillButtonDown mueisyouNumber;
    public SkillButtonDown maryokuUpNumber;
    public SkillButtonDown fbCostDownNumber;
    //スキルが増えるたびに追加していく
    void Start()
    {
        dataBasaManager = DontDestroyOnloadDataBaseManager.DataBaseManager;
        playerStatusDataBase = dataBasaManager.GetComponent<PlayerStatusDataBase>();
        SkillUpdata();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SkillUpdata()
    {
        if (content)
        {
            Instantiate(activeSkill, transform.position, transform.rotation, transform);
            if (playerStatusDataBase.fireSpireLv >= 1)
            {
                if (playerStatusDataBase.fireSpireLv <= 4) fireSpireText.text = "ファイヤースピア Lv" + playerStatusDataBase.fireSpireLv;
                else fireSpireText.text = "ファイヤースピア Lv極";
                fireSpireNumber.skillNumber = 1;
                Instantiate(fireSpire, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.rapidGireLv >= 1)
            {
                if (playerStatusDataBase.rapidGireLv <= 4) rapidFireText.text = "ラピッドファイヤー Lv" + playerStatusDataBase.rapidGireLv;
                else rapidFireText.text = "ラピッドファイヤー Lv極";
                rapidFireNumber.skillNumber = 2;
                Instantiate(rapidFire, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fireBomLv >= 1)
            {
                if (playerStatusDataBase.fireBomLv <= 4) fireBomText.text = "ファイヤーボム Lv" + playerStatusDataBase.fireBomLv;
                else fireBomText.text = "ファイヤーボム Lv極";
                fireBomTextNumber.skillNumber = 3;
                Instantiate(fireBom, transform.position, transform.rotation, transform);
            }
            //▼アクティブスキルが増えたら追加していく。

            Instantiate(pasivSkill, transform.position, transform.rotation, transform);
            if (playerStatusDataBase.firewallLv >= 1)
            {
                if (playerStatusDataBase.firewallLv <= 4) fireWallText.text = "ファイヤーウォール Lv" + playerStatusDataBase.firewallLv;
                else fireWallText.text = "ファイヤーウォール Lv極";
                fireWallNumber.skillNumber = 4;
                Instantiate(fireWall, transform.position, transform.rotation, transform);
            }
            if(playerStatusDataBase.zousyokusuuLv>=1)
            {
                if (playerStatusDataBase.zousyokusuuLv <= 4) zousyokusuuText.text = "増殖数 Lv" + playerStatusDataBase.zousyokusuuLv;
                else zousyokusuuText.text = "増殖数 Lv極";
                zousyokusuuNumber.skillNumber = 5;
                Instantiate(zousyokusuu, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fireComboLv >= 1)
            {
                if (playerStatusDataBase.fireComboLv <= 4) fireComboText.text = "ファイヤーコンボ Lv" + playerStatusDataBase.fireComboLv;
                else fireComboText.text = "ファイヤーコンボ Lv極";
                fireComboNumber.skillNumber = 6;
                Instantiate(fireCombo, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.wallChainLv >= 1)
            {
                wallComboText.text = "ウォールコンボ Lv極";
                wallComboNumber.skillNumber = 7;
                Instantiate(wallCombo, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.tazyuuEisyouLv >= 1)
            {
                if (playerStatusDataBase.tazyuuEisyouLv <= 1) tazyuuEisyouText.text = "多重詠唱 Lv" + playerStatusDataBase.tazyuuEisyouLv;
                else tazyuuEisyouText.text = "多重詠唱 Lv極";
                tazyuuEisyouNumber.skillNumber = 8;
                Instantiate(tazyuuEisyou, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fireGrabityLv >= 1)
            {
                if (playerStatusDataBase.fireGrabityLv <= 4) fireGravityText.text = "ファイヤーグラビティ Lv" + playerStatusDataBase.fireGrabityLv;
                else fireGravityText.text = "ファイヤーグラビティ Lv極";
                fireGravityNumber.skillNumber = 9;
                Instantiate(fireGravity, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.eisyouTannsyukuLv >= 1)
            {
                eisyouTannsyukuText.text = "詠唱短縮 Lv極";
                eisyouTannsyukuNumber.skillNumber = 10;
                Instantiate(eisyouTannsyuku, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.mueisyouLv >= 1)
            {
                mueisyouText.text = "無詠唱 Lv極";
                mueisyouNumber.skillNumber = 11;
                Instantiate(mueisyou, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.maryokuUpLv >= 1)
            {
                if (playerStatusDataBase.maryokuUpLv <= 12) maryokuUpText.text = "魔力アップ Lv" + playerStatusDataBase.maryokuUpLv;
                else maryokuUpText.text = "魔力アップ Lv極";
                maryokuUpNumber.skillNumber = 12;
                Instantiate(maryokuUp, transform.position, transform.rotation, transform);
            }
            if (playerStatusDataBase.fbCostDownLv >= 1)
            {
                if (playerStatusDataBase.fbCostDownLv <= 12) fbCostDownText.text = "FBコストダウン Lv" + playerStatusDataBase.fbCostDownLv;
                else fbCostDownText.text = "FBコストダウン Lv極";
                fbCostDownNumber.skillNumber = 13;
                Instantiate(fbCostDown, transform.position, transform.rotation, transform);
            }
            //▼パッシブスキルが追加になるたびに増やす

        }
    }
    public void SkillSetumei(int skillNumber)
    {
        skillSetumeiPanel.SetActive(true);
        switch(skillNumber)
        {
            case 1:
                if (playerStatusDataBase.fireSpireLv <= 4) skillMeiText.text = "ファイヤースピア Lv" + playerStatusDataBase.fireSpireLv;
                else skillMeiText.text = "ファイヤースピア Lv極";
                skillSetumeiText.text= "ファイヤーボールが敵を貫通するようになる。\n貫通確率は敵にヒットするたびに減衰する。";
                playerStatusDataBase.FireSpireLvText();
                skillKoukaText.text="貫通確率" + playerStatusDataBase.kanntuuKakuritu + "%" + "\nヒット時貫通確率減衰率" + playerStatusDataBase.kanntuuGennsuiritu + "%";
                break;
            case 2:
                if (playerStatusDataBase.rapidGireLv <= 4) skillMeiText.text = "ラビットファイヤー Lv" + playerStatusDataBase.rapidGireLv;
                else skillMeiText.text = "ラビットファイヤー Lv極";
                skillSetumeiText.text = "ファイヤーボールが敵にヒットしたときにバウンドするようになる。\nバウンド確率は敵にヒットするたびに減衰する。";
                playerStatusDataBase.RapidFireLvText();
                skillKoukaText.text ="バウンド確率" + playerStatusDataBase.rapidKakuritu + "%" + "\nヒット時バウンド確率減衰率" + playerStatusDataBase.rapidGennsuiritu+ "%";
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
                skillSetumeiText.text = "戦闘開始時にファイヤウォールを展開する。\nファイヤーウォールを通過したファイヤーボールは増殖する。\nまた、スキルレベルが上がると確率で範囲が広がる。";
                playerStatusDataBase.FireWallLvUpText();
                if (playerStatusDataBase.fireWallHannizoukakakuritu == 0) skillKoukaText.text = "展開数" + playerStatusDataBase.fireWallTennkaisuu;
                else skillKoukaText.text = "展開数" + playerStatusDataBase.fireWallTennkaisuu + "\n範囲増加確率" + playerStatusDataBase.fireWallHannizoukakakuritu + "%";
                break;
            case 5:
                if(playerStatusDataBase.zousyokusuuLv<=4) skillMeiText.text = "ウォール増殖数 Lv" +playerStatusDataBase.zousyokusuuLv;
                else skillMeiText.text = "ウォール増殖数 Lv極";
                skillSetumeiText.text = "ファイヤーウォールの増殖数が上昇する。";
                playerStatusDataBase.WallZousyokusuuLvUpText();
                skillKoukaText.text = "増殖数" + playerStatusDataBase.saisyouZousyokusuu + "～" +playerStatusDataBase.saidaiZousyokusuu;
                break;
            case 6:
                if (playerStatusDataBase.fireComboLv <= 4) skillMeiText.text = "ファイヤーコンボ Lv" + playerStatusDataBase.fireComboLv;
                else skillMeiText.text = "ファイヤーコンボ Lv極";
                skillSetumeiText.text = "ファイヤーボールの敵へのヒット数に応じて、近接戦闘時の与ダメ―ジが上昇する。";
                playerStatusDataBase.FireComboLvUpText();
                skillKoukaText.text ="上昇率" + playerStatusDataBase.fireComboZyousyouritu + "%";
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
                skillKoukaText.text = "上昇率" +playerStatusDataBase.maryokuZyousyouritu + "%";
                break;
            case 13:
                if (playerStatusDataBase.fbCostDownLv <= 12) skillMeiText.text = "FB消費MPダウン Lv" + playerStatusDataBase.fbCostDownLv;
                else skillMeiText.text = "FB消費MPダウン Lv極";
                skillSetumeiText.text = "ファイヤーボールの消費MPが減少する。";
                playerStatusDataBase.FBCostDownLvText();
                skillKoukaText.text = "減少率" +playerStatusDataBase.fireBallCostDownRitu + "%";
                break;

        }
    }

}
