using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
	public GameObject fireBallPrefab;
	public GameObject player;
	private Vector3 clickPosition;
	private PlayerStatus playerStatus;
	private float bottonDownTime;
	private float rennsyaSpeed = 0.1f;
	
	void Start()
	{
		playerStatus = player.GetComponent<PlayerStatus>();
	}
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
        {
			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;

			if (playerStatus.mp < playerStatus.fireBallCost)
			{
				return;
			}
			if (Camera.main.ScreenToWorldPoint(clickPosition).y <= 3)
			{
				playerStatus.mp -= playerStatus.fireBallCost;
				Instantiate(fireBallPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
				bottonDownTime = 0f;
			}
		}
		if (Input.GetMouseButton(0))
		{
			bottonDownTime += Time.deltaTime;
			if (bottonDownTime >= rennsyaSpeed)
			{
				clickPosition = Input.mousePosition;
				clickPosition.z = 10f;

				if (playerStatus.mp < playerStatus.fireBallCost)
				{
					return;
				}
				if (Camera.main.ScreenToWorldPoint(clickPosition).y <= 3)
				{
					playerStatus.mp -= playerStatus.fireBallCost;
					Instantiate(fireBallPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
					bottonDownTime = 0f;
				}
			}
		}
	}
}
