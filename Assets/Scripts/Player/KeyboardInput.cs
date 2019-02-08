using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField]
    private FloatReference moveSpeed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.up * moveSpeed.Value;

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.down * moveSpeed.Value;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * moveSpeed.Value;

        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * moveSpeed.Value;
    }
}