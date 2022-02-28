using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyannseruBottonDown : MonoBehaviour
{
    private GameObject[] tyekku;
    private int tyekkuLength;
    public GameObject baikyakusuruBotton;
    public GameObject misenntakuBotton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf)
        {
            if(!GameObject.Find("選択中✔(Clone)"))
            {
                misenntakuBotton.SetActive(true);
            }
            else
            {
                misenntakuBotton.SetActive(false);
            }
        }
    }
    public void KyannseruBottonDownMesod()
    {
        tyekku = GameObject.FindGameObjectsWithTag("Tyekku");
        tyekkuLength = tyekku.Length;
        for(int a = 0;a<tyekkuLength; a++)
        {
            Destroy(tyekku[a]);
        }
        misenntakuBotton.SetActive(false);
        gameObject.SetActive(false);
        baikyakusuruBotton.SetActive(false);
    }
}
