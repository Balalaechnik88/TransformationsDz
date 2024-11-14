using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotateAndMove : MonoBehaviour
{
    [SerializeField] private float _speedScale,_speedRotation;

    private void Update()
    {
        transform.localScale += _speedScale * Time.deltaTime * new Vector3(1.0f, 1.0f, 1.0f);
        transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime);
    }
}
