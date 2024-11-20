using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunInBackGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;
        Application.targetFrameRate = 60; // フレームレートを60fpsに固定
    }

}
