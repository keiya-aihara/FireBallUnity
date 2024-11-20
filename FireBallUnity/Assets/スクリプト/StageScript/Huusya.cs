using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huusya : MonoBehaviour
{
    public Vector3 rotationSpeed; // 回転速度

    void Update()
    {
        // オブジェクトを回転させる
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
