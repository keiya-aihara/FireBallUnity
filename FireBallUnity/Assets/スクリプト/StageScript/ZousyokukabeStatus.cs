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
                saisyouZousyokusuu = 1;
                saidaiZousyokusuu = 3;
                zousyokusuu = Random.Range(saisyouZousyokusuu, saidaiZousyokusuu + 1);
            }
            else if (playerStatusDataBase.zousyokusuuLv == 3)
            {
                saisyouZousyokusuu = 1;
                saidaiZousyokusuu = 4;
                zousyokusuu = Random.Range(saisyouZousyokusuu, saidaiZousyokusuu + 1);
            }
            else if (playerStatusDataBase.zousyokusuuLv == 4)
            {
                saisyouZousyokusuu = 1;
                saidaiZousyokusuu = 5;
                zousyokusuuHanntei = Random.Range(0, 100);
                if (zousyokusuuHanntei <= 24) zousyokusuu = 1;
                else if (zousyokusuuHanntei <= 49) zousyokusuu = 2;
                else if (zousyokusuuHanntei <= 69) zousyokusuu = 3;
                else if (zousyokusuuHanntei <= 89) zousyokusuu = 4;
                else if (zousyokusuuHanntei <= 99) zousyokusuu = 5;
            }
            else if (playerStatusDataBase.zousyokusuuLv == 5)
            {
                saisyouZousyokusuu = 2;
                saidaiZousyokusuu = 6;
                zousyokusuuHanntei = Random.Range(0, 100);
                if (zousyokusuuHanntei <= 24) zousyokusuu = 2;
                else if (zousyokusuuHanntei <= 49) zousyokusuu = 3;
                else if (zousyokusuuHanntei <= 69) zousyokusuu = 4;
                else if (zousyokusuuHanntei <= 89) zousyokusuu = 5;
                else if (zousyokusuuHanntei <= 99) zousyokusuu = 6;
            }
        }
        else zousyokusuu = 1;
    }
}
