using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiildScript : MonoBehaviour
{
    public int siildHp;
    public Text HpText;
    void Update()
    {
        HpText.text = siildHp.ToString();
        if (siildHp <= 0)
            Destroy(gameObject);
    }
}
