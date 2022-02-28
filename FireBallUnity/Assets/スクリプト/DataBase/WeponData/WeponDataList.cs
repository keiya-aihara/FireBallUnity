using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "MyScriptable/Create WeponData", fileName = "WeponDataList")]  
public class WeponDataList : ScriptableObject
{	
	void Start()
    {

    }
	public List<WeponData> weponDatas = new List<WeponData>();
	[Serializable]
	public class WeponData
	{
		public GameObject srushEffect;
		public GameObject soubiIcon;
		public GameObject readoIcon;

		[Header("装備ナンバー")]
		public int no;
		[Header("装備名")]
		public string name;
		[Space(1)]
		[Header("装備種別")]
		public bool kinnkyoriWepon;
		public bool ennkyoriWepon;
		public bool yoroi;
		public bool sonota;
		[Space(1)]
		[Header("レア度")]
		public bool nomal;
		public bool rea;
		public bool superRea;
		public bool epik;
		public bool legendary;
		public bool god;
		[Space(1)]
		[Header("装備ステータス")]
		public int maxHp;
		public int maxMp;
		public int fireBallCost;
		public int kougekiryoku;
		public float kinnkyoriKaisinnritu;
		public int maryoku;
		public float ennkyoriKaisinnsitu;
		public int bougyoryoiku;
		public float kaisinnTaisei;
		public float meityuuritu;
		public float kaihiritu;
		[Space(1)]
		public float kougekiHinndo;
		public float destroyTime;
		public float srushSpeed;
		public float nokkubakku;
		public float kougekiHanni;
		[Space(1)]
		[Header("強化後ステータス")]
		public int kyoukagoMaxHp;
		public int kyoukagoMaxMp;
		public int kyoukagoKougekiryoku;
		public int kyoukagoMaryoku;
		public int kyoukagoBougyoryoku;
		public float kyoukagoMeityuuritu;
		public float kyoukagoKaihiritu;
		[Space(1)]
		public int kyoukaLv;
		public string kyoukaLvName;
		public float kyoukaBairitu;
		public int sonotaKyoukaStatus;
		[Space(1)]
		public int baikyakuKinngaku;
		[Space(1)]
		[Header("称号")]
		public string syougouName;
		public bool syougouRea;
		public bool syougouSuperRea;
		public bool syougouEpikRea;
		public string syougouBairitu;
		public int syougouMaxHp;
		public int syougouMaxMp;
		public int syougouFireBallCost;
		public int syougouKougekiryoku;
		public int syougouMamryoku;
		public float syougouKinnkyoriKaisinnritu;
		public float syougouEnnkyoriKaisinnritu;
		public int syougouBougyoryoku;
		public float syougouKaisinnTaisei;
		public float syougouMeityuuritu;
		public float syougouKaihiritu;
		[Space(1)]
		[Header("ギフト")]
		public string giftName;
		public string giftBairituName;
		public int bairitu;
		[Space(1)]
		[Header("ロック")]
		public bool keyLock;
	}
	public void Hpzyunn()
    {
		weponDatas.Sort((a, b) => b.kyoukagoMaxHp - a.kyoukagoMaxHp);
		foreach(var a in weponDatas)
        {
			Debug.Log("HP " + a.maxHp);
        }
	}
	public void Mpzyunn()
    {
		weponDatas.Sort((a, b) => b.kyoukagoMaxMp - a.kyoukagoMaxMp);
	}
	public void FbCostzyunn()
    {
		weponDatas.Sort((a, b) => a.fireBallCost - b.fireBallCost);
	}
	public void Kougekiryokuzyunn()
	{
		weponDatas.Sort((a, b) => b.kyoukagoKougekiryoku - a.kyoukagoKougekiryoku);
		foreach (var a in weponDatas)
		{
			Debug.Log("攻撃力 " + a.kougekiryoku);
		}

	}
	public void Maryokuzyunn()
    {
		weponDatas.Sort((a , b) => b.kyoukagoMaryoku - a.kyoukagoMaryoku);
    }
	public void Kinnkyorikaisinnrituzyunn()
    {
		weponDatas.Sort((a, b) => b.kinnkyoriKaisinnritu.CompareTo(a.kinnkyoriKaisinnritu));
    }
	public void EnnkyoriKaisinnrituzyunn()
    {
		weponDatas.Sort((a, b) => b.ennkyoriKaisinnsitu.CompareTo(a.syougouEnnkyoriKaisinnritu));
    }

	public void Bougyoryokuzyunn()
	{
		weponDatas.Sort((a, b) => b.kyoukagoBougyoryoku - a.kyoukagoBougyoryoku);
	}
	public void Kaisinntaiseizyunn()
    {
		weponDatas.Sort((a, b) => b.kaisinnTaisei.CompareTo(a.kaisinnTaisei));
    }
	public void Meityuurituzyunn()
    {
		weponDatas.Sort((a, b) => b.kyoukagoMeityuuritu.CompareTo(a.kyoukagoMeityuuritu));
	}
	public void Kaihirituzyunn()
    {
		weponDatas.Sort((a, b) => b.kyoukagoKaihiritu.CompareTo(a.kyoukagoKaihiritu));
    }
	public void Syougekiryokuzyunn()
    {
		weponDatas.Sort((a, b) => b.nokkubakku.CompareTo(a.nokkubakku));
    }
	public void Kougekihinndozyunn()
    {
		weponDatas.Sort((a, b) => a.kougekiHinndo.CompareTo(b.kougekiHinndo));
    }
	public void Kougekihannizyunn()
    {
		weponDatas.Sort((a, b) => b.kougekiHanni.CompareTo(b.kougekiHanni));
    }
	public void Nyuusyuzyunn()
    {
		weponDatas.Sort((a, b) => a.no - b.no);
    }
}
