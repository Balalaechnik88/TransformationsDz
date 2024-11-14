using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _gameObject;
    [SerializeField] private float _followSpeed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _gameObject.position, _followSpeed * Time.deltaTime);
    }
}
