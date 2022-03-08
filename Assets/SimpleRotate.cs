using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up);
    }
}
