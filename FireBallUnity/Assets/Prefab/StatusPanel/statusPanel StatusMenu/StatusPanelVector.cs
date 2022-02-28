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
    public KyoukaPanel kyoukaPanelScript;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Scroll View 装備ステータス ステータス1(Clone)")
        {
            transform.localPosition = new Vector2(0, -72);
        }
        if (gameObject.name == "Scroll View 装備ステータス ステータス2(Clone)")
        {
            transform.localPosition = new Vector2(0, 642);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void kyoukaBottonDown()
    {
        kyoukaPanelScript = kyoukaPanel.GetComponent<KyoukaPanel>();
        kyoukaPanelScript.number = number;
        kyoukaPanelScript.kinnkyoriWepon = kinnkyoriWepon;
        kyoukaPanelScript.ennkyoriWepon = ennkyoriWepon;
        kyoukaPanelScript.yoroi = yoroi;
        kyoukaPanelScript.sonota = sonota;
        Instantiate(kyoukaPanel,transform.position,transform.rotation,gameObject.transform);

    }
}
