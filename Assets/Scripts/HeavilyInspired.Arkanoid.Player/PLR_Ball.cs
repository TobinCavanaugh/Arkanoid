using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLR_Ball : MonoBehaviour
{
    public float speed = 1f;

    public Rigidbody rb;

    public Vector3 dir = new Vector3(-90, 90, 90);

    private void Reset() {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        rb.velocity = dir.normalized * speed * Time.deltaTime;
    }

    
    private void OnCollisionEnter(Collision other) {
        dir = Vector3.Reflect(other.transform.position, transform.position);
    }

    //void FixedUpdate()
    //{
    //    transform.Translate(transform.forward * speed, Space.World);
    //}
}
