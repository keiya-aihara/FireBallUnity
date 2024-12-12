using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
    // バウンドの強さを調整するための係数
    public float bounceForce = 5f;

    // バウンドさせる対象のタグ
    public string targetTag = "FireBall";
    public float x1;
    public float x2;
    public float y1;
    public float y2;
    // トリガーに他のオブジェクトが触れたときに呼ばれるメソッド
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 衝突したオブジェクトが指定したタグを持っているかチェック
        if (other.CompareTag(targetTag))
        {
            // 衝突したオブジェクトのRigidbody2Dコンポーネントを取得
            Rigidbody2D rb = other.attachedRigidbody;

            if (rb != null)
            {
                // 左上方向のランダムなベクトルを生成
                Vector2 randomDirection = new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)).normalized;

                // ランダムな方向に力を加える
                rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
            }
        }
    }
}
