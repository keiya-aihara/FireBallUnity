using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class BGMSEVolume : MonoBehaviour
{
    public Slider seSlider;
    public Slider bgmSlider;
    public float seVolume;
    public float bgmVolume;

    public MenuBGMScript menuBGMScript;

    public OnnryouSaveData onnryouSaveData;

    private void Start()
    {
        VolumeLoad();

        menuBGMScript.audioSource.volume = bgmVolume;
    }
    public void VolumeSave()
    {
        onnryouSaveData = new OnnryouSaveData();
        onnryouSaveData.bgmVolume = bgmVolume;
        onnryouSaveData.seVolume = seVolume;

        string json = JsonUtility.ToJson(onnryouSaveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.onnryou.json", json);
    }
    public void VolumeLoad()
    {
        string path = Application.persistentDataPath + "/savefile.onnryou.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);//ファイル読み込み
            //Debug.Log(json);
            OnnryouSaveData loadData = JsonUtility.FromJson<OnnryouSaveData>(json);//読み込んだJsonデータをSaveDataクラスの形式に変換

            bgmVolume = loadData.bgmVolume;
            seVolume = loadData.seVolume;

        }
    }

    public void SyokiSettei()
    {
        bgmSlider.value = bgmVolume;
        seSlider.value = seVolume;
    }
    public void BGMHennkou()
    {
        bgmVolume = bgmSlider.value;
        menuBGMScript.audioSource.volume = bgmVolume;
        VolumeSave();
    }
    public void SEHennkou()
    {
        seVolume = seSlider.value;
        VolumeSave();
    }
}
