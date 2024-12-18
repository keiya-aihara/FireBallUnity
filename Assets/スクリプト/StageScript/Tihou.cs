using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tihou : MonoBehaviour
{
    public GameObject fireBall;// 発射するオブジェクト
    private GameObject hassyaFireBall;
    private GameObject hassyaFireBall2;
    private GameObject hassyaFireBall3;
    public Transform firePoint;   // 大砲の発射点
    public Transform firePoint2;
    public Transform firePoint3;
    public bool onePoint;
    public bool twoPoint;
    public bool threePoint;
    public float launchForce = 10f;     // 発射する力

    public Vector3 rotationSpeed; // 回転速度
    private bool pulas=true;
    private bool mainasu = false;

    public float xPlas;
    public float xMainasu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (onePoint)
        {
            if (collision.gameObject.tag == "FireBall")
            {
                Destroy(collision.gameObject);

                hassyaFireBall = Instantiate(fireBall, firePoint.position, firePoint.rotation);



                Rigidbody2D rb = hassyaFireBall.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * launchForce, ForceMode2D.Impulse);
            }
        }
        else if(twoPoint)
        {
            if (collision.gameObject.tag == "FireBall")
            {
                Destroy(collision.gameObject);

                hassyaFireBall = Instantiate(fireBall, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = hassyaFireBall.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * launchForce, ForceMode2D.Impulse);

                hassyaFireBall2 = Instantiate(fireBall, firePoint2.position, firePoint2.rotation);
                Rigidbody2D rb2 = hassyaFireBall2.GetComponent<Rigidbody2D>();
                rb2.AddForce(firePoint2.up * launchForce, ForceMode2D.Impulse);
            }
        }
        else if (threePoint)
        {
            if (collision.gameObject.tag == "FireBall")
            {
                Destroy(collision.gameObject);

                hassyaFireBall = Instantiate(fireBall, firePoint.position, firePoint.rotation);
                Rigidbody2D rb = hassyaFireBall.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.up * launchForce, ForceMode2D.Impulse);

                hassyaFireBall2 = Instantiate(fireBall, firePoint2.position, firePoint2.rotation);
                Rigidbody2D rb2 = hassyaFireBall2.GetComponent<Rigidbody2D>();
                rb2.AddForce(firePoint2.up * launchForce, ForceMode2D.Impulse);

                hassyaFireBall3 = Instantiate(fireBall, firePoint3.position, firePoint3.rotation);
                Rigidbody2D rb3 = hassyaFireBall3.GetComponent<Rigidbody2D>();
                rb3.AddForce(firePoint3.up * launchForce, ForceMode2D.Impulse);
            }
        }
    }

    void Update()
    {
        //Debug.Log(transform.localEulerAngles.z);
        if (pulas)
        {
            if (transform.localEulerAngles.z <= xPlas)
            {
                // オブジェクトを回転させる
                transform.Rotate(rotationSpeed * Time.deltaTime);
            }
            else
            {
                mainasu = true;
                pulas = false;
            }
        }
        if (mainasu)
        {
            if (transform.localEulerAngles.z >= xMainasu)
            {
                // オブジェクトを回転させる
                transform.Rotate(-rotationSpeed * Time.deltaTime);
            }
            else
            {
                mainasu = false;
                pulas = true;
            }
        }

    }
}
