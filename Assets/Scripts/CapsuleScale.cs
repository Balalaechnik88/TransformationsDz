using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
    [SerializeField] private float _speedScale;
    
    private void Update()
    {
        transform.localScale += _speedScale * Time.deltaTime * new Vector3(1.0f, 1.0f, 1.0f);
    }
}
