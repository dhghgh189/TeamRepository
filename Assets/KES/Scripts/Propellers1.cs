using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propellers1 : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime, Space.World);
    }
}
