using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZidouBaikyakuPanelOpen : MonoBehaviour
{
    public SystemDatabase systemDatabase;
    private void Start()
    {
        systemDatabase = DontDestroyOnloadDataBaseManager.DataBaseManager.GetComponent<SystemDatabase>();
    }
    public void ZidouBaikyakuStart()
    {
        systemDatabase.StartSub();
    }
    public void ZidouBaikyakuPanelOpenSub()
    {
        systemDatabase.ZidouBaikyakuPanelOpen();
    }
    public void NomalSinaiTrue()
    {
        systemDatabase.NomalSinaiTrue();
    }
    public void NomalSubeteTrue()
    {
        systemDatabase.NomalSubeteTrue();
    }
    public void NomalMuinnTrue()
    {
        systemDatabase.NomalMuinnTrue();
    }
    public void ReaSinaiTrue()
    {
        systemDatabase.ReaSinaiTrue();
    }
    public void ReaSubeteTrue()
    {
        systemDatabase.ReaSubeteTrue();
    }
    public void ReaMuinnTrue()
    {
        systemDatabase.ReaMuinnTrue();
    }
    public void SuperReaSinaiTrue()
    {
        systemDatabase.SuperReaSinaiTrue();
    }
    public void SuperReaSubeteTrue()
    {
        systemDatabase.SuperReaSubeteTrue();
    }
    public void SuperReaMuinnTrue()
    {
        systemDatabase.SuperReaMuinnTrue();
    }
}
