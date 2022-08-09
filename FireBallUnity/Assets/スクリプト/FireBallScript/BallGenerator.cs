using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallGenerator : MonoBehaviour
{
    public GameObject fireBallPrefab;
    public GameObject player;
    private Vector3 clickPosition;
    public PlayerStatus playerStatus;
    public PlayerStatusDataBase playerStatusDataBase;
    private float bottonDownTime;
    public float rennsyaSpeed = 0.6f;
    private int tazyuueisyouDouziHassyasuu;

    public GameObject fireSpirePrefab;
    public GameObject rapidFirePrefab;
    public GameObject fireBomPrefab;

    public bool fireSpireButton;
    public bool rapidFireButton;
    public bool fireBomButton;

    public SkillButtonColor fireSpireButtonScript;
    public SkillButtonColor rapidFireButtonScript;
    public SkillButtonColor bomFireBallButtonScript;

    public GameObject fireSpireButtonGameObject;
    public GameObject rapidFireButtonGameObject;
    public GameObject bomFireBallButtonGameObject;
         
    void Start()
    {
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
        fireSpireButton = false;
        rapidFireButton = false;
        fireBomButton = false;
        if (playerStatusDataBase.fireSpireLv == 0) fireSpireButtonGameObject.SetActive(false);
        if (playerStatusDataBase.rapidGireLv == 0) rapidFireButtonGameObject.SetActive(false);
        if (playerStatusDataBase.fireBomLv == 0) bomFireBallButtonGameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
            clickPosition.z = 10f;

            if (playerStatus.mp < playerStatus.fireBallCost)
            {
                return;
            }
            else if (Camera.main.ScreenToWorldPoint(clickPosition).y <= 3)
            {
                tazyuueisyouDouziHassyasuu = Random.Range(playerStatus.tazyuuEisyouSaisyouHassyasuu, playerStatus.tazyuuEisyouSaidaiHassyasuu + 1);
                if (fireSpireButton)
                {
                    playerStatus.mp -= playerStatus.fireBallCost;
                    for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                    {
                        if (a == 0) Instantiate(fireSpirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                        else Instantiate(fireSpirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                    }
                }
                else if (rapidFireButton)
                {

                    playerStatus.mp -= playerStatus.fireBallCost;
                    for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                    {
                        if (a == 0) Instantiate(rapidFirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                        else Instantiate(rapidFirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                    }
                }
                else if (fireBomButton)
                {
                    playerStatus.mp -= playerStatus.fireBallCost;
                    for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                    {
                        if (a == 0) Instantiate(fireBomPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                        else Instantiate(fireBomPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                    }
                }
                else
                {
                    playerStatus.mp -= playerStatus.fireBallCost;
                    for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                    {
                        if (a == 0) Instantiate(fireBallPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                        else Instantiate(fireBallPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                    }
                }
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
                    tazyuueisyouDouziHassyasuu = Random.Range(playerStatus.tazyuuEisyouSaisyouHassyasuu, playerStatus.tazyuuEisyouSaidaiHassyasuu + 1);
                    if (fireSpireButton)
                    {
                        for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                        {
                            if (a == 0) Instantiate(fireSpirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                            else Instantiate(fireSpirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                        }
                    }
                    else if (rapidFireButton)
                    {

                        for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                        {
                            if (a == 0) Instantiate(rapidFirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                            else Instantiate(rapidFirePrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                        }
                    }
                    else if (fireBomButton)
                    {

                        for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                        {
                            if (a == 0) Instantiate(fireBomPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                            else Instantiate(fireBomPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                        }
                    }
                    else
                    {
                        playerStatus.mp -= playerStatus.fireBallCost;
                        for (int a = 0; a < tazyuueisyouDouziHassyasuu; a++)
                        {
                            if (a == 0) Instantiate(fireBallPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x, 5f, 0), fireBallPrefab.transform.rotation);
                            else Instantiate(fireBallPrefab, new Vector3(Camera.main.ScreenToWorldPoint(clickPosition).x + Random.Range(-0.3f, 0.3f), 5f, 0), fireBallPrefab.transform.rotation);
                        }
                    }
                    bottonDownTime = 0f;
                }
            }
        }
    }
    public void FireSpireButtonDown()
    {
        if(fireSpireButton)
        {
            fireSpireButton = false;
            fireSpireButtonScript.skillButtonColorBool = false;
            fireSpireButtonScript.SkillButtonColorUpdate();
            playerStatus.fireBallCost = playerStatusDataBase.fireBallCost;
        }
        else
        {
            fireSpireButton = true;
            fireSpireButtonScript.skillButtonColorBool = true;
            rapidFireButton = false;
            rapidFireButtonScript.skillButtonColorBool = false;
            fireBomButton = false;
            rapidFireButtonScript.skillButtonColorBool = false;

            playerStatus.fireBallCost = Mathf.CeilToInt(playerStatusDataBase.fireBallCost * 1.5f);

            fireSpireButtonScript.SkillButtonColorUpdate();
            rapidFireButtonScript.SkillButtonColorUpdate();
            bomFireBallButtonScript.SkillButtonColorUpdate();
        }
    }
    public void RapidFireButtonDown()
    {
        if (rapidFireButton)
        {
            rapidFireButton = false;
            rapidFireButtonScript.skillButtonColorBool = false;
            rapidFireButtonScript.SkillButtonColorUpdate();
            playerStatus.fireBallCost = playerStatusDataBase.fireBallCost;

        }
        else
        {
            fireSpireButton = false;
            fireSpireButtonScript.skillButtonColorBool = false;
            rapidFireButton = true;
            rapidFireButtonScript.skillButtonColorBool = true; ;
            fireBomButton = false;
            bomFireBallButtonScript.skillButtonColorBool = false;

            playerStatus.fireBallCost = Mathf.CeilToInt(playerStatusDataBase.fireBallCost * 1.5f);

            fireSpireButtonScript.SkillButtonColorUpdate();
            rapidFireButtonScript.SkillButtonColorUpdate();
            bomFireBallButtonScript.SkillButtonColorUpdate();
        }
    }
    public void FireBomButtonDown()
    {
        if (fireBomButton)
        {
            fireBomButton = false;
            bomFireBallButtonScript.skillButtonColorBool = false;
            bomFireBallButtonScript.SkillButtonColorUpdate();
            playerStatus.fireBallCost = playerStatusDataBase.fireBallCost;

        }
        else
        {
            fireSpireButton = false;
            fireSpireButtonScript.skillButtonColorBool = false;
            rapidFireButton = false;
            rapidFireButtonScript.skillButtonColorBool = false;
            fireBomButton = true;
            bomFireBallButtonScript.skillButtonColorBool = true;

            playerStatus.fireBallCost = Mathf.CeilToInt(playerStatusDataBase.fireBallCost*1.5f);

            fireSpireButtonScript.SkillButtonColorUpdate();
            rapidFireButtonScript.SkillButtonColorUpdate();
            bomFireBallButtonScript.SkillButtonColorUpdate();
        }
    }

}
