using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grass_Wall_Scr : MonoBehaviour
{
    [SerializeField] private float ____speed = 1f;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * ____speed);
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
        if (other.tag == "Grass")
        {
            Destroy(other.gameObject);
        }
    }
}