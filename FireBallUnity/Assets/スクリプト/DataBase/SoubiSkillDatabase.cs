using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoubiSkillDatabase : MonoBehaviour
{
    public GameObject kougekiSkillText;
    public GameObject kaihukuSkillText;
    public GameObject damageKeigennSkillText;

    public GameObject kaihukuHpText;

    public int[] skillNumber=new int[5];

    [Header("装備スキル一覧")]
    public SoubiSkillDataList soubiSkillDataList;
    public SoubiSkillDataList.SoubiSkillData GetSoubiSkillData(int no)
    {
        SoubiSkillDataList.SoubiSkillData soubiSkillData = new SoubiSkillDataList.SoubiSkillData();

        soubiSkillData = soubiSkillDataList.soubiSkillDatas.Find((x) => x.no == no);

        return soubiSkillData;
    }
}
