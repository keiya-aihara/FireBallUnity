using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "MyScriptable/Create SoubiSkillData", fileName = "SoubiSkillDataList")]
public class SoubiSkillDataList : ScriptableObject
{

    public List<SoubiSkillData>soubiSkillDatas;
    [Serializable]
    public class SoubiSkillData
    {
        [Header("装備スキルNo")]
        public int no;
        [Header("スキル名")]
        public string skillName;
        [Header("スキル分類")]
        public bool activeSkill;
        public bool passiveSkill;
        [Header("スキル説明")]
        public string skillSetumei;
        [Header("威力")]
        public float iryoku;

        [Header("連続斬り用数値")]
        public int rennzokugiriKakuritu;//連続斬り継続確率
        public int rennzokugiriKaisuu;//連続斬り回数
        [Header("補給用数値")]
        public int hokyuuKakuritu;//補給発動確率
        public float hokyuuKaihukuWariai;//回復割合
        [Header("採掘用数値")]
        public int saikutuKaisuu;//採掘判定回数
        [Header("ダメージ軽減用数値")]
        public float damageKeigennKakuritu;//ダメージ軽減確率
        public float damageKeigennRitu;//ダメージ軽減率
        [Header("吸収用数値")]
        public float kyuusyuuWariai;//吸収量
        [Header("強斬り用数値")]
        public int kyougiriHinndo;//強斬り発動頻度
        [Header("アシッドボール用数値")]
        public float asidBallKakuritu;//アシッドボール酸状態付与率
        [Header("アシッドスラッシュ用数値")]
        public float asidSrushKakuritu;//アシッドスラッシュ酸状態付与率
        [Header("魔剣の力[火]用数値")]
        public float makennnotikaraKakuritu;//魔剣の力[火]発動確率
        public int makennnotikaraHassyasuu;//Fireball発射数
        [Header("石化反撃用数値")]
        public float sekikaHanngekiKakuritu;
        [Header("魔力暴走用数値")]
        public float maryokuBousoukakuritu;
    }

}
