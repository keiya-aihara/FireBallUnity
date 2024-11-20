using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaruInstantiate : MonoBehaviour
{
    private Vector2 randomPosition;
    public float taruTime;
    public float rennsyaSpeed;
    public GameObject taruPrefab;
    void Update()
    {
        randomPosition = new Vector3(Random.Range(-2.1f, 2.1f), 5);
        taruTime += Time.deltaTime;
        if (taruTime >= rennsyaSpeed)
        {
            Instantiate(taruPrefab, randomPosition, taruPrefab.transform.rotation);

            taruTime = 0f;
        }
    }
}
