using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScripts : MonoBehaviour
{

    int cnt = 0;

    private void Awake() {

        Debug.Log($"{cnt++}. Awake 角青.");

    }

    private void OnEnable() {

        Debug.Log($"{cnt++}. OnEnable 角青.");

    }

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log($"{cnt++}. Start 角青.");

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Update 角青.");
        cnt++;

    }

    private void OnDisable() {

        Debug.Log($"{cnt++}. OnDisable 角青.");

    }

    private void OnDestroy() {

        Debug.Log($"{cnt++}. OnDestroy 角青.");

    }
}
