using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPanelSetActive : MonoBehaviour
{
    public GameObject statusPanelSouko;
    public GameObject statusPanelStatusMenu;

    public GameObject skillPanel;
    public void SkillPanelOpen()
    {
        skillPanel.SetActive(true);
    }
}
