using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    Transform tr;
    public float speed;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        tr.Rotate(Vector3.up * speed);
    }
}