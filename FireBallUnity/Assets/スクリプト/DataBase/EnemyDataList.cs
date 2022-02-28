using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �G�̏��̃X�N���v�^�u���E�I�u�W�F�N�g
/// </summary>
[CreateAssetMenu(menuName = "MyScriptable/Create EnemyData", fileName = "EnemyDataList")]   // ���̑�������ݒ肷���Unity�ɃA�Z�b�g�Ƃ��ăX�N���v�^�u���E�I�u�W�F�N�g���쐬�ł��܂��B
public class EnemyDataList : ScriptableObject
{   // MonoBehaviour�N���X�̑���ɁAScriptableObject�N���X���p�����Ă��܂��B

	// �G�̏��(EnemyData)���܂Ƃ߂����X�g
	public List<EnemyData> enemyDatas = new List<EnemyData>();

	/// �G�̏��(1�̂��̏��)
	[Serializable]// ���̑�������Y��Ȃ��悤�ɂ��Ă��������B�ݒ肵�Ȃ��ƃC���X�y�N�^�[�ɕ\������܂���B
	public class EnemyData
	{
		[Header("�G�X�e�[�^�X")]
		public int no;
		public int lebel;
		public bool rea;
		public string enemyName;
		[Header("�푰")]
		public bool mazyuu;
		public bool ninngenn;
		public bool mazinn;
		public bool husi;
		public bool akuma;
		public bool ryuu;
		public bool kami;
		[Header("�X�e�[�^�X")]
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
		[Header("�h���b�v")]
		public int exp;
		public int gold;
		public int dropItemSuu;
		public int[] dropItemNos;
		public GameObject[] dropSyougou;
		[Header("�����h���b�v��")]
		public float nomalDropRitu;
		public float reaDropRitu;
		public float superReaDropRitu;
		public float epikDropRitu;
		public float legendaryDropRitu;
		public float godDropRitu;
		[Header("�̍��h���b�v��")]
		public float reaSyougouDropRitu;
		public float superReaSyougouDropRitu;
		public float epikSyougouDropRitu;
		[Header("�M�t�g�h���b�v��")]
		public float giftDropRitu;
	}
	void Start()
    {
		
    }
}
