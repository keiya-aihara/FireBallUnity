using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnloadDataBaseManager : MonoBehaviour
{
	private static GameObject mInstance;
	public WeponDateBaseManager weponDateBaseManager;
	public EnnkyoriWeponDataBaseManager ennkyoriWeponDataBaseManager;
	public YoroiDataBaseManager yoroiDataBaseManager;
	public SonotaDataBaseManager sonotaDataBaseManager;

	public static GameObject DataBaseManager
	{
		get
		{
			return mInstance;
		}
	}

	void Awake()
	{
		if (mInstance == null)
		{
			DontDestroyOnLoad(gameObject);
			mInstance = gameObject;
			SortSyokika();
		}
		else
		{
			SortSyokika();
			Destroy(gameObject);
		}
	}
	private void SortSyokika()
    {
		weponDateBaseManager.weponDataList.Nyuusyuzyunn();
		ennkyoriWeponDataBaseManager.weponDataList.Nyuusyuzyunn();
		yoroiDataBaseManager.weponDataList.Nyuusyuzyunn();
		sonotaDataBaseManager.weponDataList.Nyuusyuzyunn();
		Debug.Log("É\Å[Égèâä˙âª");
	}
}
