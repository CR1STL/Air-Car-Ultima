using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy_Scr : MonoBehaviour
{
    [SerializeField] private float __speed = 1f;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * __speed);
        if (transform.position.y < -14)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Score_Manager.instance.AddPoint();
        }
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<Player_Control_Scr>().Damage();
        }
    }
}