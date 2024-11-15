using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        transform.localScale += _speed * Time.deltaTime * new Vector3(1.0f, 1.0f, 1.0f);
    }
}
