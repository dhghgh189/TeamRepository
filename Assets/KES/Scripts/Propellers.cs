using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propellers : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        /*transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);*/
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }
}
