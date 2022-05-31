using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Road_Scr : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * _speed);
    }
}