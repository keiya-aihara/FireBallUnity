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

		public bool huyoZumi;
	}
}
