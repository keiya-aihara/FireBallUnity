using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTextController : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 200, 0));
        StartCoroutine(DestroyObject());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DestroyObject());
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(this.gameObject);
    }
}