using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZennkainoBoukennStageName : MonoBehaviour
{
    public Text text;
    public bool textUpdata = true;

    private void Update()
    {
        if (textUpdata)
        {
            text.text = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>().zennkainoStageName;
            textUpdata = false;
        }

    }


}
