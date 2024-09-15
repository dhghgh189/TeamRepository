using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private void MoveObject()
    {
        transform.position += Vector3.forward * _moveSpeed * Time.deltaTime;
    }
}
