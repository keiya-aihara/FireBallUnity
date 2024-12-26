using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : MonoBehaviour
{
	public GameObject[] enemys;
	private PlayerStatus playerStatus;
	public GameObject player;
	private float weitTime;
	public ResultSceneManager resultSceneManager;
	public bool a;
	private bool b;
    private bool winSEOneShot=true;

    public int stageNo;
    private int stageKuriaKaisuu;
    public int nannidoNo;
    public GameObject reaMonster;

    public List<int> numbers = new List<int>();
	public List<int> numbers2 = new List<int>();
    void Start()
	{
		playerStatus = player.GetComponent<PlayerStatus>();

        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().EnnkyoriBGMStart();//BGM

		a = false;
		b = true;
        resultSceneManager = GameObject.Find("ResultManager").GetComponent<ResultSceneManager>();

        stageKuriaKaisuu= DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>().GetStageKuriaKaisuu(stageNo);
        if (stageKuriaKaisuu >= 3000)
        {
            if (Random.Range(0, 10000) < 3000)
            {
                Instantiate(reaMonster, new Vector2(0, -4), transform.rotation);
                Debug.Log("レアモンスターが現れた");
            }
        }
        else
        {
            if (Random.Range(0, 10000) < stageKuriaKaisuu + 100)
            {
                Instantiate(reaMonster, new Vector2(0, -4), transform.rotation);
                Debug.Log("レアモンスターが現れた");
            }
        }

    }
    void Update()
	{

		enemys = GameObject.FindGameObjectsWithTag("Enemy");
        //Debug.Log(enemys.Length);
		if (enemys.Length == 0)
		{

			if (player.transform.position.y <= -5f)
			{
                if(winSEOneShot)
                {
                    DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().WinSEStart();
                    winSEOneShot = false;
                }
                weitTime += Time.deltaTime;
                //Debug.Log(weitTime);

				if (weitTime >= 4f)
				{
					if (b)
					{
                        
						SoubiGet();
						b = false;
					}
					if (a)
					{
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>().SoubiScritableSave();
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>().StatusUpdate();
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KousekiDataBaseManager>().TrophySave();
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KyoukasekiManager>().KyoukasekiSave();
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().MoneySave();
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KakutokuDataBase>().KakutokuSave();
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KakutokuDataBase>().GekihasuuSave();

                        if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<Nannido>().syosinnsyanoMiti) nannidoNo = 0;
                        else if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<Nannido>().boukennsyanoSirenn)nannidoNo = 1;
                        else if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<Nannido>().eiyuunoMiti) nannidoNo = 2;
                        else if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<Nannido>().yuusyanoTyousenn) nannidoNo = 3;
                        else if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<Nannido>().dennsetunoSirenn) nannidoNo = 4;
                        else if (DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<Nannido>().kamigaminoRyouiki) nannidoNo = 5;

                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>().StageKuriaKaisuu(stageNo,nannidoNo);

                        SceneManager.LoadScene("Result");
                        DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().WinBGMStart();
                    }

				}
			}
		}
		if (playerStatus.hp <= 0)
		{

            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<KyoukasekiManager>().KyoukasekiSave();
            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MoneyManager>().MoneySave();
            SceneManager.LoadScene("GameOver");
            DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<MenuBGMScript>().LoseBGMStart();
        }
	}
	public void SoubiGet()
    {

        for (int i = 0; i < resultSceneManager.getSoubi.Count; i++)
		{
			numbers.Add(i);
		}
		for (int i = 0; i < resultSceneManager.getSoubi.Count; i++)
		{
			numbers2.Add(i);
		}

		for (int a = 0; a < resultSceneManager.getSoubi.Count; a++)
		{
			int number = Random.Range(0, numbers.Count);

			resultSceneManager.getSoubi[a].GetComponent<ItemController>().dropNumber = numbers[number];
			numbers.RemoveAt(number);
		}
		for (int a = 0; a < resultSceneManager.getSoubi.Count; a++)
		{
			int number2 = Random.Range(0, numbers2.Count);

			resultSceneManager.getSoubi[a].GetComponent<ItemController>().dropNumber2 = numbers2[number2];
			numbers2.RemoveAt(number2);
			
		}
        resultSceneManager.b = true;
        //dropSoubi.getSoubi.RemoveRange(0, dropSoubi.getSoubi.Count);

    }

}
