using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KyoukaLv : MonoBehaviour
{
    public int kyoukaLv;
    private Text text;
    private void Start()
    {
        transform.localPosition = new Vector3(0, 0);
        text = gameObject.GetComponent<Text>();

        
    }
    private void Update()
    {
        text.text = "LV." + kyoukaLv;
    }
}
