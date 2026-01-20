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
vpn://AAAA_3icdY1LC4JAFEb_isy6wqLQ2kUJQghRUNRGBp10tHkwD83E_97MSLRqdeGew3d6QCFBYOOBLaHojaF3FIhgTcDEAzmSmcBcYUb_GBmjD1ykDRJylBbmCTlOR2AePZBINDhDqeq4C8FxZsp_M1-FC6ZYxp5OawuLtGFmTVMlOnNzNyE0GGxIqzLNoYKuY7M16iy_zpPKn5frWbhvV6fL4RUnbRvqII_EWd7KOg6iZaXv_g4MwwcyO1
        
            Destroy(other.gameObject);
        }
    }
}
