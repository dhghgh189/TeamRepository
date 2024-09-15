using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float moveSpeed = 5f; // ������Ʈ �̵� �ӵ�
    public float ascendSpeed = 3f; // ��� �� �ϰ� �ӵ�

    void Update()
    {
        // �Է°� �������� (WASD �Ǵ� ȭ��ǥ Ű)
        float moveX = Input.GetAxis("Horizontal"); // �¿� �̵� (A/D �Ǵ� ��/�� ����Ű)
        float moveZ = Input.GetAxis("Vertical");   // �յ� �̵� (W/S �Ǵ� ��/�Ʒ� ����Ű)
        float moveY = 0f; // �⺻ Y �� �̵� ���� 0

        // ��� �� �ϰ� �Է� ���� (Space/Shift �Ǵ� ����� ���� Ű)
        if (Input.GetKey(KeyCode.Space)) // Space Ű�� ���
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftShift)) // Shift Ű�� �ϰ�
        {
            moveY = -1f;
        }

        // �̵��� ���� ����
        Vector3 move = new Vector3(moveX, moveY * ascendSpeed, moveZ);

        // ������Ʈ �̵�
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
