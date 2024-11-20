using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenntouBGMManager : MonoBehaviour
{
    public AudioSource FireBallSE;
    public AudioSource playerAtackSE;
    public AudioSource missSE;
    public AudioSource kaisinnSE;

    public void FireBallSEPlay()
    {
        FireBallSE.Play();
    }
    public void PlayerAtackSEPlay()
    {
        playerAtackSE.Play();
    }
    public void MissSEPlay()
    {
        missSE.Play();
    }
    public void KaisinnSE()
    {
        kaisinnSE.Play();
    }
}
