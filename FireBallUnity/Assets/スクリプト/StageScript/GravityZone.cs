using UnityEngine;

public class GravityZone : MonoBehaviour
{
    private Rigidbody2D rb;
    private float originalGravityScale; // 元の重力スケールを保存

    void Start()
    {
        // Rigidbody2Dコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            originalGravityScale = rb.gravityScale; // 元の重力スケールを保存
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 重力ゾーンに入った場合
        if (collision.CompareTag("ZyuuryokuHantenZone") && rb != null)
        {
            rb.gravityScale = -originalGravityScale; // 重力を反転
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // 重力ゾーンから出た場合
        if (collision.CompareTag("ZyuuryokuHantenZone") && rb != null)
        {
            rb.gravityScale = originalGravityScale; // 重力を元に戻す
        }
    }
}
