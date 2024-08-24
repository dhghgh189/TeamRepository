using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScripts : MonoBehaviour
{

    int cnt = 0;

    private void Awake() {

        Debug.Log($"{cnt++}. Awake ����.");

    }

    private void OnEnable() {

        Debug.Log($"{cnt++}. OnEnable ����.");

    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log($"{cnt++}. Start ����.");

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Update ����.");
        cnt++;

    }

    private void OnDisable() {

        Debug.Log($"{cnt++}. OnDisable ����.");

    }

    private void OnDestroy() {

        Debug.Log($"{cnt++}. OnDestroy ����.");

    }
}
