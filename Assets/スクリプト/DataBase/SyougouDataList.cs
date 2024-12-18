using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "MyScriptable/Create SyougouData", fileName = "SyougouDataList")]   // この属性情報を設定するとUnityにアセットとしてスクリプタブル・オブジェクトを作成できます。
public class SyougouDataList : ScriptableObject
{
		public List<SyougouData> syougyouDatas = new List<SyougouData>();
	[Serializable]
	public class SyougouData
	{
		public int no;
		public string syougouName;
		public string syougouBairitu;
		public bool rea;
		public bool superRea;
		public bool epikRea;

		public int maxHpPlus;
		public int maxMpPlus;
		public int fireBallCostPlus;
		public int kougekiryokuPlus;
		public int maryokuPlus;
		public float kinnkyoriKaisinnrituPlus;
		public float ennkyoriKaisinnrituPlus;
		public int bouggyoryokuPlus;
		public float kaisinnTaisei;
		public float meityuurituPlus;
		public float kaihirituPlus;

        public float syougekiryoku;
        public float srushHinndo;
        public float kougekiHanni;

        [Header("特攻")]
        public int mazyuuTokkou;
        public int ninngennTokkou;
        public int mazinnTokkou;
        public int husiTokkou;
        public int akumaTokkou;
        public int ryuuTokkou;
        public int kamiTokkou;
        [Space(1)]
        [Header("装備ドロップ率倍率")]
        public int soubiDropBairitu;
        [Space(1)]
        [Header("称号付き装備装備ドロップ率")]
        public int syougouDropRitu;
        [Space(1)]
        [Header("ギフト付与装備ドロップ率")]
        public int soubiGifthuyosoubiDropritu;
        public bool huyoZumi;
	}
}
