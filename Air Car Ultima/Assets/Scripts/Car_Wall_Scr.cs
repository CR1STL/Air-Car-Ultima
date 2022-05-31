using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Car_Wall_Scr : MonoBehaviour
{
    [SerializeField] private float ___speed = 1f;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * ___speed);
        if (transform.position.y < -14)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Player_Control_Scr>().Death_Damage();
        }
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}