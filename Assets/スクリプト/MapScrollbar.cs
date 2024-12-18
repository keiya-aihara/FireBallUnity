using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapScrollbar : MonoBehaviour
{
    public Scrollbar scrollbar;
    private void Start()
    {
        scrollbar.value = 0;
    }
}
