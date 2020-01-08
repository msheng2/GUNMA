using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breadaction : MonoBehaviour
{
    public float speed = 0f;
    public GameObject go;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }
}
