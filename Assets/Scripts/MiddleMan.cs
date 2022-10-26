using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleMan : MonoBehaviour
{
    public Transform a;
    public Transform b;
    void Start()
    {

    }

    void Update()
    {
        transform.position = (a.position + b.position) / 2;
    }
}
