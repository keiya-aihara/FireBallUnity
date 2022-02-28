using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject[] enemys;
	private PlayerStatus playerStatus;
	public GameObject player;
	private float weitTime;
	public ResultSceneManager dropSoubi;
	public bool a;
	private bool b;

	public List<int> numbers = new List<int>();
	public List<int> numbers2 = new List<int>();
	void Start()
	{
		playerStatus = player.GetComponent<PlayerStatus>();
		a = false;
		b = true;
	}
	void Update()
	{

		enemys = GameObject.FindGameObjectsWithTag("Enemy");
		if (enemys.Length == 0)
		{
			if (player.transform.position.y <= -5.7)
			{
				weitTime += Time.deltaTime;

				if (weitTime >= 3f)
				{
					if (b)
					{
						SoubiGet();
						b = false;
					}
					if (a)
					{
						SceneManager.LoadScene("Result");
					}

				}
			}
		}
		if (playerStatus.hp <= 0)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
	public void SoubiGet()
    {
		dropSoubi = GameObject.Find("ResultManager").GetComponent<ResultSceneManager>();
		for (int i = 0; i < dropSoubi.getSoubi.Count; i++)
		{
			numbers.Add(i);
		}
		for (int i = 0; i < dropSoubi.getSoubi.Count; i++)
		{
			numbers2.Add(i);
		}

		for (int a = 0; a < dropSoubi.getSoubi.Count; a++)
		{
			int number = Random.Range(0, numbers.Count);

			dropSoubi.getSoubi[a].GetComponent<ItemController>().dropNumber = numbers[number];
			numbers.RemoveAt(number);
		}
		for (int a = 0; a < dropSoubi.getSoubi.Count; a++)
		{
			int number2 = Random.Range(0, numbers2.Count);

			dropSoubi.getSoubi[a].GetComponent<ItemController>().dropNumber2 = numbers2[number2];
			numbers2.RemoveAt(number2);
			dropSoubi.b = true;
		}

	}

}
