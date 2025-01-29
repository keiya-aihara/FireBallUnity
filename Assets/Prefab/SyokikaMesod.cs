using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyokikaMesod : MonoBehaviour
{
    public WeponDataList kinnkyoriWepons;
    public WeponDataList ennkyoriWepons;
    public WeponDataList yorois;
    public WeponDataList sonotas;

    public WeponDataList.WeponData kinnkyoriWepon;
    public WeponDataList.WeponData ennkyoriWepon;
    public WeponDataList.WeponData yoroi;
    public WeponDataList.WeponData sonota1;
    public WeponDataList.WeponData sonota2;

    public PlayerStatusDataBase playerStatusDataBase;
    public KyoukasekiManager kyoukasekiManager;
    public MoneyManager moneyManager;
    public KousekiDataBaseManager kousekiDataBaseManager;
    public StageZissekiDatabase stageZissekiDatabase;
    public SystemDatabase systemDatabase;
    public KakutokuDataBase soubiKakutokuDataBase;
    [ContextMenu("ステータス・スキル初期化")]
    private void StatusSyokikaMesod()
    {
        playerStatusDataBase.StatusSyokika();
    }

    [ContextMenu("装備初期化")]
    private void SoubiSyokika()
    {

        kinnkyoriWepons.weponDatas.Clear();
        kinnkyoriWepons.weponDatas.Add(kinnkyoriWepon);

        ennkyoriWepons.weponDatas.Clear();
        ennkyoriWepons.weponDatas.Add(ennkyoriWepon);

        yorois.weponDatas.Clear();
        yorois.weponDatas.Add(yoroi);

        sonotas.weponDatas.Clear();
        sonotas.weponDatas.Add(sonota1);
        sonotas.weponDatas.Add(sonota2);
        //sonotas.weponDatas.RemoveRange(3, sonotas.weponDatas.Count - 1);

        playerStatusDataBase.SoubiScritableSave();
        playerStatusDataBase.SoubiScritableLoad();
    }
    [ContextMenu("強化石初期化")]
    private void KyoukasekiSyokika()
    {
        kyoukasekiManager.KyoukasekiSyokika();
    }
    [ContextMenu("金初期化")]
    private void MoneySyokika()
    {
        moneyManager.MoneySyokika();
    }
    [ContextMenu("トロフィー初期化")]
    private void TorophySyokika()
    {
        kousekiDataBaseManager.TorophySyokika();
    }
    [ContextMenu("ステージクリア回数初期化")]
    private void StageClearSyokika()
    {
        stageZissekiDatabase.StaziZissekiSyokika();
    }

    [ContextMenu("自動売却初期化")]
    private void BaikyakuStageNameSyokika()
    {
        systemDatabase.BaikyakuStageNameSyokika();
    }
    [ContextMenu("装備獲得数、撃破数初期化")]
    private void SoubiKakutokusuuSyokika()
    {
        soubiKakutokuDataBase.KakutokuSuuSyokika();
    }
    [ContextMenu("すべて初期化")]
    private void AllSaveSyokika()
    {
        StatusSyokikaMesod();
        SoubiSyokika();
        SoubiKakutokusuuSyokika();
        KyoukasekiSyokika();
        MoneySyokika();
        TorophySyokika();
        StageClearSyokika();
        BaikyakuStageNameSyokika();
       
    }
}
