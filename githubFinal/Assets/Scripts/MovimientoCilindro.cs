using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCilindro : MonoBehaviour
{
    Transform transform;
    public float rotationSpeed = 40f;
    void Start()
    {
        transform = GetComponent<Transform>();
    }
    void Update()
    {

        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
