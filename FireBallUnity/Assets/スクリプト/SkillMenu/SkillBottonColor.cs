using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillBottonColor : MonoBehaviour
{
    public Button[] fireWallBottonImage;
    public int fireWallLevel;
    public Button[] fireChainImage;
    public int fireChainLevel;
    public Button[] zousyokusuuImage;
    public int zousyokusuuLevel;

    public Button[] maryokuUpImage;
    public int maryokuUpLevel;
    public Button[] fireBallCostDownImage;
    public int fireBallConstDownLevel;

    public Color kiiro;
    public Color haiiro;
    void Start()
    {
        FireWallBottonColor();
        FireChainBottonColor();
        ZousyokusuuBottonColor();
        MaryokuUpButtonColor();
        FireBallCostDownButtonColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FireWallBottonColor()
    {
        for (int a = 0; a <= fireWallLevel - 1; a++)
        {
            fireWallBottonImage[a].image.color = kiiro;
        }
        for (int b = fireWallLevel + 1; b <= 4; b++)
        {
            fireWallBottonImage[b].image.color = haiiro;
        }
    }
    public void FireChainBottonColor()
    {
        for (int a = 0; a <= fireChainLevel - 1; a++)
        {
            fireChainImage[a].image.color = kiiro;
        }
        for (int b = fireChainLevel + 1; b <= 4; b++)
        {
            fireChainImage[b].image.color = haiiro;
        }
    }
    public void ZousyokusuuBottonColor()
    {
        if (zousyokusuuLevel == 0)
        {
            if (fireWallLevel == 0 || fireChainLevel == 0)
            {
                zousyokusuuImage[0].image.color = haiiro;
            }
            for (int a = 1; a <= zousyokusuuLevel - 1; a++)
            {
                zousyokusuuImage[a].image.color = kiiro;
            }
            for (int b = zousyokusuuLevel + 1; b <= 4; b++)
            {
                zousyokusuuImage[b].image.color = haiiro;
            }
        }
        else
        {
            for (int a = 0; a <= zousyokusuuLevel - 1; a++)
            {
                zousyokusuuImage[a].image.color = kiiro;
            }
            for (int b = zousyokusuuLevel + 1; b <= 4; b++)
            {
                zousyokusuuImage[b].image.color = haiiro;
            }
        }
    }
    public void MaryokuUpButtonColor()
    {
        for (int a = 0; a <= maryokuUpLevel - 1; a++)
        {
            maryokuUpImage[a].image.color = kiiro;
        }
        for (int b = maryokuUpLevel + 1; b <= 12; b++)
        {
            maryokuUpImage[b].image.color = haiiro;
        }
    }
    public void FireBallCostDownButtonColor()
    {
        for (int a = 0; a <= fireBallConstDownLevel - 1; a++)
        {
            fireBallCostDownImage[a].image.color = kiiro;
        }
        for (int b = fireBallConstDownLevel + 1; b <= 12; b++)
        {
            fireBallCostDownImage[b].image.color = haiiro;
        }
    }
}
