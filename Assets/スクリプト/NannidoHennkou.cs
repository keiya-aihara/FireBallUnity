using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NannidoHennkou : MonoBehaviour
{
    public Color32 color1;
    public Color32 color2;
    public Color32 color3;
    public Color32 color4;
    public Color32 color5;
    public Color32 color6;
    public Text text;

    private Nannido nannido;
    private void Start()
    {
        nannido = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<Nannido>();

        if (nannido.syosinnsyanoMiti)
        {
            text.text = "初心者の道";
            gameObject.GetComponent<Image>().color = color1;
        }
        else if (nannido.boukennsyanoSirenn)
        {
            text.text = "冒険者の試練";
            gameObject.GetComponent<Image>().color = color2;
        }
        else if (nannido.eiyuunoMiti)
        {
            text.text = "英雄の道";
            gameObject.GetComponent<Image>().color = color3;
        }
        else if (nannido.yuusyanoTyousenn)
        {
            text.text = "勇者の挑戦";
            gameObject.GetComponent<Image>().color = color4;
        }
        else if (nannido.dennsetunoSirenn)
        {
            text.text = "伝説の試練";
            gameObject.GetComponent<Image>().color = color5;
        }
        else if (nannido.kamigaminoRyouiki)
        {
            text.text = "神々の領域";
            gameObject.GetComponent<Image>().color = color6;
        }
    }
    public void NannidoHennkouMesod()
    {
        if(nannido.syosinnsyanoMiti)
        {
            nannido.boukennsyanoSirenn = true;
            nannido.syosinnsyanoMiti = false;
            text.text = "冒険者の試練";
            gameObject.GetComponent<Image>().color = color2;
        }
        else if(nannido.boukennsyanoSirenn)
        {
            nannido.eiyuunoMiti = true;
            nannido.boukennsyanoSirenn = false;
            text.text = "英雄の道";
            gameObject.GetComponent<Image>().color = color3;
        }
        else if(nannido.eiyuunoMiti)
        {
            nannido.yuusyanoTyousenn = true;
            nannido.eiyuunoMiti = false;
            text.text = "勇者の挑戦";
            gameObject.GetComponent<Image>().color = color4;
        }
        else if(nannido.yuusyanoTyousenn)
        {
            nannido.dennsetunoSirenn = true;
            nannido.yuusyanoTyousenn = false;
            text.text = "伝説の試練";
            gameObject.GetComponent<Image>().color = color5;
        }
        else if(nannido.dennsetunoSirenn)
        {
            nannido.kamigaminoRyouiki = true;
            nannido.dennsetunoSirenn = false;
            text.text = "神々の領域";
            gameObject.GetComponent<Image>().color = color6;
        }
        else if(nannido.kamigaminoRyouiki)
        {
            nannido.syosinnsyanoMiti = true;
            nannido.kamigaminoRyouiki = false;
            text.text = "初心者の道";
            gameObject.GetComponent<Image>().color = color1;
        }
    }
}
