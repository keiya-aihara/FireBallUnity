using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftLv : MonoBehaviour
{
    private Text text;
    public int giftLv;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(0, 44);
        text = gameObject.GetComponent<Text>();

        text.text = "<"+giftLv+">";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
