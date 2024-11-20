using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPanelVector : MonoBehaviour
{
    public int number;
    public bool kinnkyoriWepon;
    public bool ennkyoriWepon;
    public bool yoroi;
    public bool sonota;
    public GameObject kyoukaPanel;
    public GameObject baikyakuPanel;
    public KyoukaPanel kyoukaPanelScript;
    public bool a;
    public GameObject content;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(a)
        {
            gameObject.SetActive(false);
        }
    }
    public void kyoukaBottonDown()
    {
        kyoukaPanelScript.number = number;
        kyoukaPanelScript.kinnkyoriWepon = kinnkyoriWepon;
        kyoukaPanelScript.ennkyoriWepon = ennkyoriWepon;
        kyoukaPanelScript.yoroi = yoroi;
        kyoukaPanelScript.sonota = sonota;
        kyoukaPanel.SetActive(true);

    }
    public void CloseStatusPanel()
    {
        foreach (Transform n in content.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
        if(kyoukaPanel.activeSelf)
        {
            kyoukaPanelScript.TaikagatarimasennIieBottonDown();
        }
        gameObject.SetActive(false);
        baikyakuPanel.SetActive(false);
        kyoukaPanel.SetActive(false);


    }
}
