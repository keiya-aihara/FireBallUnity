using UnityEngine;

public class MukouWallController : MonoBehaviour
{
    [Header("ふり幅")]
    public float amplitude = 1f;
    [Header("周期")]
    public float period = 1f;
    [Header("速度")]
    public float speed = 1f;

    private float timer;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        timer += Time.deltaTime;

        float x = amplitude * Mathf.Sin(2 * Mathf.PI * timer / period);
        Vector3 pos = startPos + new Vector3(x, 0f, 0f);
        transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
    }
}

