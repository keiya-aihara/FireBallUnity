using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimikRotate : MonoBehaviour
{
    public Vector3 rotationSpeed; // 回転速度
    private float countTime;
    public float rotationTime;
    private int vectorX;
    private void Start()
    {
        //vectorX = Random.Range(0, 2);
    }
    void Update()
    {
        /*
        countTime += Time.deltaTime;

        if(countTime>=rotationTime)
        {
            vectorX = Random.Range(0, 2);
            countTime = 0;
        }

        if(vectorX==0)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(-rotationSpeed * Time.deltaTime);
        }
        */
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
