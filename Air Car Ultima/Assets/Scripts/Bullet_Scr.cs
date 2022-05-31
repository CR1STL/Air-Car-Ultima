using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet_Scr : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);

        if (transform.position.y > 13)
        {
            Destroy(gameObject);
        }
    }
}