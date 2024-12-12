using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenSeisokutiPanel : MonoBehaviour
{
    public GameObject seisokutiPanelDai;
    public GameObject batuButton;
    public GameObject seisokutiPanel;

    public Text seisokutiText;
    public GameObject[] seisokutiTexts;
    public EnemyDataList.EnemyData enemyBase;

    public void OpenSeisokutiPanelMesod()
    {
        seisokutiPanelDai.SetActive(true);
        batuButton.SetActive(true);

        

        for (int a=0; a < enemyBase.stage.Length;a++)
        {
            seisokutiText.text = enemyBase.stage[a];
            Instantiate(seisokutiText.gameObject, seisokutiPanel.transform);
        }
    }
    public void CloseSeisokutiPanelMesod()
    {
        foreach (Transform child in seisokutiPanel.transform)
        {
            Destroy(child.gameObject);
        }

        seisokutiPanelDai.SetActive(false);
        batuButton.SetActive(false);

    }
}
