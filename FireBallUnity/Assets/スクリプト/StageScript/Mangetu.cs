using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mangetu : MonoBehaviour
{
    public float speed = 1.0f; // 円運動の速度
    public float radius = 5.0f; // 円の半径

    private float angle = 0.0f; // 現在の角度

    private void Update()
    {
        // 現在の角度を更新
        angle += speed * Time.deltaTime;

        // オブジェクトの位置を円運動の位置に設定
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}

