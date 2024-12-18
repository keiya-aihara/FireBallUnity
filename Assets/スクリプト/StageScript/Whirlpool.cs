using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whirlpool : MonoBehaviour
{
    public float pullStrength = 5f; // 中心に引き寄せる力
    public float rotateSpeed = 200f; // 渦に回転させるスピード
    public float whirlpoolRadius = 2f; // 渦の半径
    public float stopDuration = 3f; // 渦が停止する時間
    public float minInterval = 10f; // 渦が停止する最小間隔
    public float maxInterval = 20f; // 渦が停止する最大間隔

    private bool isStopped = false; // 渦が停止しているかどうか
    private float stopTimer; // 渦の停止タイマー
    private float intervalTimer; // 渦が次に停止するまでの時間

    private void Start()
    {
        // 渦が停止するまでの初期時間を設定
        intervalTimer = Random.Range(minInterval, maxInterval);
    }

    private void Update()
    {
        // 渦の回転を管理
        if (!isStopped)
        {
            // 渦が停止していない場合、回転させる
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }

        // 次に停止するまでの時間をカウントダウン
        intervalTimer -= Time.deltaTime;

        if (intervalTimer <= 0 && !isStopped)
        {
            // 渦を停止する
            StartCoroutine(StopWhirlpool());
        }
    }

    private IEnumerator StopWhirlpool()
    {
        // 渦を停止
        isStopped = true;

        // 停止時間を待つ
        yield return new WaitForSeconds(stopDuration);

        // 渦を再開
        isStopped = false;

        // 次に停止するまでの時間をリセット
        intervalTimer = Random.Range(minInterval, maxInterval);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // 渦が停止している間は引き寄せない
        if (isStopped)
        {
            return;
        }

        // オブジェクトのタグが"FireBall"でなければ何もしない
        if (other.CompareTag("FireBall"))
        {
            // 渦に巻き込まれるオブジェクトがRigidbody2Dを持っているか確認
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // 渦の中心へのベクトルを計算
                Vector2 directionToCenter = (Vector2)transform.position - rb.position;

                // 渦の中心までの距離を計算
                float distanceToCenter = directionToCenter.magnitude;

                // 渦の範囲内であれば力を加える
                if (distanceToCenter < whirlpoolRadius)
                {
                    // 回転させる動き
                    rb.AddTorque(rotateSpeed * Time.deltaTime);

                    // 中心に引き寄せる動き
                    Vector2 pullForce = directionToCenter.normalized * pullStrength * (whirlpoolRadius - distanceToCenter) / whirlpoolRadius;
                    rb.AddForce(pullForce);
                }
            }
        }
    }
}
