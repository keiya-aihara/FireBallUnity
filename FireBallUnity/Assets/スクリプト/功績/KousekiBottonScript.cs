using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KousekiBottonScript : MonoBehaviour
{
    public GameObject toubatusuuScrollViewCanvas;
    public GameObject nyuusyusuuScrollViewCanvas;
    public GameObject kyoukasuuScrollViewCanvas;
    public GameObject reasyugekihasuuScrollViewCanvas;

    public GameObject toubatusuuScrollViewBotton;
    public GameObject nyuusyusuuScrollViewBotton;
    public GameObject kyoukasuuScrollViewBotton;
    public GameObject reasyugekihasuuScrollViewBottn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToubatusuuScrollViewBottonDown()
    {
        if(!toubatusuuScrollViewCanvas.activeSelf)
        {
            toubatusuuScrollViewCanvas.SetActive(true);
            nyuusyusuuScrollViewCanvas.SetActive(false);
            kyoukasuuScrollViewCanvas.SetActive(false);
            reasyugekihasuuScrollViewCanvas.SetActive(false);

            toubatusuuScrollViewBotton.SetActive(false);
            nyuusyusuuScrollViewBotton.SetActive(true);
            kyoukasuuScrollViewBotton.SetActive(true);
            reasyugekihasuuScrollViewBottn.SetActive(true);
        }
    }
    public void NyuusyusuuScrollViewBottonDown()
    {
        if (!nyuusyusuuScrollViewCanvas.activeSelf)
        {
            toubatusuuScrollViewCanvas.SetActive(false);
            nyuusyusuuScrollViewCanvas.SetActive(true);
            kyoukasuuScrollViewCanvas.SetActive(false);
            reasyugekihasuuScrollViewCanvas.SetActive(false);

            toubatusuuScrollViewBotton.SetActive(true);
            nyuusyusuuScrollViewBotton.SetActive(false);
            kyoukasuuScrollViewBotton.SetActive(true);
            reasyugekihasuuScrollViewBottn.SetActive(true);
        }
    }
    public void KyoukasuuScrollViewBottonDown()
    {
        if (!kyoukasuuScrollViewCanvas.activeSelf)
        {
            toubatusuuScrollViewCanvas.SetActive(false);
            nyuusyusuuScrollViewCanvas.SetActive(false);
            kyoukasuuScrollViewCanvas.SetActive(true);
            reasyugekihasuuScrollViewCanvas.SetActive(false);

            toubatusuuScrollViewBotton.SetActive(true);
            nyuusyusuuScrollViewBotton.SetActive(true);
            kyoukasuuScrollViewBotton.SetActive(false);
            reasyugekihasuuScrollViewBottn.SetActive(true);
        }
    }
    public void ReasyugekihasuuScrollViewBottonDown()
    {
        if (!reasyugekihasuuScrollViewCanvas.activeSelf)
        {
            toubatusuuScrollViewCanvas.SetActive(false);
            nyuusyusuuScrollViewCanvas.SetActive(false);
            kyoukasuuScrollViewCanvas.SetActive(false);
            reasyugekihasuuScrollViewCanvas.SetActive(true);

            toubatusuuScrollViewBotton.SetActive(true);
            nyuusyusuuScrollViewBotton.SetActive(true);
            kyoukasuuScrollViewBotton.SetActive(true);
            reasyugekihasuuScrollViewBottn.SetActive(false);
        }
    }

}
