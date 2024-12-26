using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BoukennnotebikiSyousaiOpen : MonoBehaviour
{
    public Text titleText;
    public Text syousaiText;
    public string titleString;
    public string syousaiString;

    public void SetSyousaiPanel()
    {
        titleText.text = titleString;
        syousaiText.text = syousaiString;
    }
}
