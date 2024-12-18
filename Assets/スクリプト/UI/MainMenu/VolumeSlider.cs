using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public BGMSEVolume bGMSEVolume;
    public Slider bgmSlider;
    public Slider seSlider;
    public void BgmSeVolumeSet()
    {
        bGMSEVolume = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<BGMSEVolume>();
        bGMSEVolume.bgmSlider = bgmSlider;
        bGMSEVolume.seSlider = seSlider;

        bGMSEVolume.SyokiSettei();
    }
    public void BGMHennkou()
    {
        bGMSEVolume.bgmVolume = bgmSlider.value;
        bGMSEVolume.menuBGMScript.audioSource.volume = bGMSEVolume.bgmVolume;
        bGMSEVolume.VolumeSave();
    }
    public void SEHennkou()
    {
        bGMSEVolume.seVolume = seSlider.value;
        bGMSEVolume.VolumeSave();
    }
}
