using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{



    [SerializeField]
    float rotationY = 10f;

    void Update()
    {
        transform.Rotate(0.0f, rotationY * Time.deltaTime, 0.0f);
    }
}
