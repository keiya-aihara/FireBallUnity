using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZousyokukabeStatus : MonoBehaviour
{
    public int zousyokusuu;
    public int zousyokusuuHanntei;
    public ZousyokukabeUI zousyokukabeUI;
    private PlayerStatusDataBase playerStatusDataBase;
    private int saisyouZousyokusuu;
    private int saidaiZousyokusuu;
    void Start()
    {
        playerStatusDataBase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<PlayerStatusDataBase>();
        Zousyokusuu();
        zousyokukabeUI.ZousyokukabeUiUpdata();
    }
    void Updata()
    {
        
    }
    public void Zousyokusuu()
    {
        if (playerStatusDataBase.zousyokusuuLv >= 1)
        {
            if (playerStatusDataBase.zousyokusuuLv == 1)
            {
                saisyouZousyokusuu = 1;
                saidaiZousyokusuu = 2;
                zousyokusuu = Random.Range(saisyouZousyokusuu, saidaiZousyokusuu + 1);
            }
            else if (playerStatusDataBase.zousyokusuuLv == 2)
            {
                saisyouZousyokusuu = 2;
                saidaiZousyokusuu = 3;
                zousyokusuu = Random.Range(saisyouZousyokusuu, saidaiZousyokusuu + 1);
            }
            else if (playerStatusDataBase.zousyokusuuLv == 3)
            {
                saisyouZousyokusuu = 3;
                saidaiZousyokusuu = 4;
                zousyokusuu = Random.Range(saisyouZousyokusuu, saidaiZousyokusuu + 1);
            }
            else if (playerStatusDataBase.zousyokusuuLv == 4)
            {
                saisyouZousyokusuu = 4;
                saidaiZousyokusuu = 5;
                zousyokusuu = Random.Range(saisyouZousyokusuu, saidaiZousyokusuu + 1);
            }
            else if (playerStatusDataBase.zousyokusuuLv == 5)
            {
                saisyouZousyokusuu = 4;
                saidaiZousyokusuu = 6;
                zousyokusuu = Random.Range(saisyouZousyokusuu, saidaiZousyokusuu + 1);
            }
        }
        else zousyokusuu = 1;
    }
}
