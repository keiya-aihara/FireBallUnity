using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float upperLimitY;  // 上昇するY座標の上限
    public float lowerLimitY;  // 下降するY座標の下限
    public float speed = 2.0f; // 移動速度

    public bool movingUp = true;  // 上昇しているかどうかのフラグ

    void Update()
    {
        // 現在のオブジェクトのY座標を取得
        Vector3 position = transform.position;

        // 上昇中の場合
        if (movingUp)
        {
            position.y += speed * Time.deltaTime; // Y座標を増加

            // 上限に達したらフラグを切り替え
            if (position.y >= upperLimitY)
            {
                position.y = upperLimitY; // 上限に固定
                movingUp = false; // 下降に切り替え
            }
        }
        // 下降中の場合
        else
        {
            position.y -= speed * Time.deltaTime; // Y座標を減少

            // 下限に達したらフラグを切り替え
            if (position.y <= lowerLimitY)
            {
                position.y = lowerLimitY; // 下限に固定
                movingUp = true; // 上昇に切り替え
            }
        }

        // 新しい位置を設定
        transform.position = position;
    }
}
