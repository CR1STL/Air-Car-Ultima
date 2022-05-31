using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grass_Scr : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _speed);
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
            Destroy(gameObject);
            other.gameObject.GetComponent<Player_Control_Scr>().Damage();
        }
    }
}