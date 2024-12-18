using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KuriaKaisuuText : MonoBehaviour
{
    public Text text;
    public Text stageNameText;
    private int stageNo;
    private int clearKaisuu;
    void Start()
    {
        KuriaKaisuuUpdate();
    }
    public void KuriaKaisuuUpdate()
    {
        stageNo = int.Parse(stageNameText.text.Substring(0, 2));
        clearKaisuu = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<StageZissekiDatabase>().GetStageKuriaKaisuu(stageNo);
        text.text = "クリア回数" + clearKaisuu.ToString("N0") + "回";
    }
}
