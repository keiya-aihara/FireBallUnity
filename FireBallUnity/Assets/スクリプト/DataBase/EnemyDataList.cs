using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の情報のスクリプタブル・オブジェクト
/// </summary>
[CreateAssetMenu(menuName = "MyScriptable/Create EnemyData", fileName = "EnemyDataList")]   // この属性情報を設定するとUnityにアセットとしてスクリプタブル・オブジェクトを作成できます。
public class EnemyDataList : ScriptableObject
{   // MonoBehaviourクラスの代わりに、ScriptableObjectクラスを継承しています。

	// 敵の情報(EnemyData)をまとめたリスト
	public List<EnemyData> enemyDatas = new List<EnemyData>();

	/// 敵の情報(1体ずつの情報)
	[Serializable]// この属性情報を忘れないようにしてください。設定しないとインスペクターに表示されません。
	public class EnemyData
	{
		[Header("敵ステータス")]
		public int no;
		public int lebel;
		public bool rea;
		public string enemyName;
		[Header("種族")]
		public bool mazyuu;
		public bool ninngenn;
		public bool mazinn;
		public bool husi;
		public bool akuma;
		public bool ryuu;
		public bool kami;
		[Header("ステータス")]
		public int maxHp;
		public int hp;
		public int kougekiryoku;
		public float kaisinnritu;
		public int bougyoryoku;
		public float kaisinnTaisei;
		public int mahouBougyoryoku;
		public float meityuuritu;
		public float kaihiritu;
		public float kougekiHinndo;
		public float kougekiHanni;
		public float speed;
		public float nokkubakkuBougyo;
		[Header("ドロップ")]
		public int exp;
		public int gold;
		public int dropItemSuu;
		public int[] dropItemNos;
		public GameObject[] dropSyougou;
		[Header("装備ドロップ率")]
		public float nomalDropRitu;
		public float reaDropRitu;
		public float superReaDropRitu;
		public float epikDropRitu;
		public float legendaryDropRitu;
		public float godDropRitu;
		[Header("称号ドロップ率")]
		public float reaSyougouDropRitu;
		public float superReaSyougouDropRitu;
		public float epikSyougouDropRitu;
		[Header("ギフトドロップ率")]
		public float giftDropRitu;
	}
	void Start()
    {
		
    }
}
