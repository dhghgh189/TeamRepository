using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float moveSpeed = 5f; // 오브젝트 이동 속도
    public float ascendSpeed = 3f; // 상승 및 하강 속도

    void Update()
    {
        // 입력값 가져오기 (WASD 또는 화살표 키)
        float moveX = Input.GetAxis("Horizontal"); // 좌우 이동 (A/D 또는 좌/우 방향키)
        float moveZ = Input.GetAxis("Vertical");   // 앞뒤 이동 (W/S 또는 위/아래 방향키)
        float moveY = 0f; // 기본 Y 축 이동 값은 0

        // 상승 및 하강 입력 감지 (Space/Shift 또는 사용자 지정 키)
        if (Input.GetKey(KeyCode.Space)) // Space 키로 상승
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftShift)) // Shift 키로 하강
        {
            moveY = -1f;
        }

        // 이동할 방향 설정
        Vector3 move = new Vector3(moveX, moveY * ascendSpeed, moveZ);

        // 오브젝트 이동
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
