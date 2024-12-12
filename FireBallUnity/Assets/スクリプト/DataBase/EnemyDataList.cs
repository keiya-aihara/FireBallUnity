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
		//public int lebel;
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
        [Header("HP")]
        public int maxHp;
		//public int hp;
        [Header("攻撃力")]
        public int kougekiryoku;
        [Header("会心率")]
        public float kaisinnritu;
        [Header("防御力")]
        public int bougyoryoku;
        [Header("会心耐性")]
        public float kaisinnTaisei;
        [Header("魔法防御力")]
        public int mahouBougyoryoku;
        [Header("命中率")]
        public float meityuuritu;
        [Header("回避率")]
        public float kaihiritu;
        [Header("攻撃頻度")]
        public float kougekiHinndo;
        //[Header("攻撃範囲")]
        //public float kougekiHanni;
        [Header("速度")]
        public float speed;
        [Header("緩衝力")]
        public float nokkubakkuBougyo;
        [Header("出現ステージ")]
        public string[] stage;
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
