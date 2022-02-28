using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInventory : MonoBehaviour
{
    private GameObject scrollViewKinnKyoriWeponStatus;
    private GameObject scrollViewEnnkyoriWeponStatus;
    private GameObject scrollViewYoroiStatus;
    private GameObject scrollViewSonotaStatus1;
    private GameObject scrollViewSonotaStatus2;
    private Vector3 clickPosition;
    public GameObject sortPanel;
    private GameObject[] gameObjectList;
    private GameObject databaseManager;
    private PlayerStatusDataBase playerStatusDataBase;
    // Start is called before the first frame update
    void Start()
    {
        gameObjectList = Resources.FindObjectsOfTypeAll<GameObject>();
        databaseManager = GameObject.Find("DataBaseManager");
        playerStatusDataBase = databaseManager.GetComponent<PlayerStatusDataBase>();

        foreach (var a in gameObjectList)
        {
            if (a.name == "Scroll View 近距離武器 ステータス")
            {
                scrollViewKinnKyoriWeponStatus = a;
            }
            if (a.name == "Scroll View 遠距離武器 ステータス")
            {
                scrollViewEnnkyoriWeponStatus = a;
            }
            if (a.name == "Scroll View 鎧装備 ステータス")
            {
                scrollViewYoroiStatus = a;
            }
            if (a.name == "Scroll View その他装備 ステータス1")
            {
                scrollViewSonotaStatus1 = a;
            }
            if (a.name == "Scroll View その他装備 ステータス2")
            {
                scrollViewSonotaStatus2 = a;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
            if (Camera.main.ScreenToWorldPoint(clickPosition).y <= -2)
            {
                if (GameObject.Find("Scroll View 装備ステータス ステータス1(Clone)"))
                {
                    return;
                }
                else
                {
                    scrollViewKinnKyoriWeponStatus.gameObject.SetActive(false);
                    scrollViewEnnkyoriWeponStatus.gameObject.SetActive(false);
                    scrollViewYoroiStatus.gameObject.SetActive(false);
                    scrollViewSonotaStatus1.gameObject.SetActive(false);
                    scrollViewSonotaStatus2.gameObject.SetActive(false);
                    sortPanel.gameObject.SetActive(false);
                    
                }
            }
        }
    }
}
