using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneStageChange : MonoBehaviour
{
    public GameObject boukennsuruPanel;
    public Text stageName;
    public Text boukennsuruStageName;
    public void BoukennsuruPanelOpen()
    {
        boukennsuruPanel.SetActive(true);
        boukennsuruStageName.text = stageName.text;
    }
}
