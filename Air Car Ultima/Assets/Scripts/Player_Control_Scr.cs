using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player_Control_Scr : MonoBehaviour
{
    [SerializeField] private float _speed = 7f;
    [SerializeField] private int HP = 5;
    public GameObject Bullet;
    public Text HPText;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
        HPText.text = "HP: " + HP;
        Movement();
        if (transform.position.x > 17)
        {
            transform.position = new Vector3(17, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -17)
        {
            transform.position = new Vector3(-17, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 8)
        {
            transform.position = new Vector3(transform.position.x, 8, transform.position.z);
        }
        if (transform.position.y < -8)
        {
            transform.position = new Vector3(transform.position.x, -8, transform.position.z);
        }
        if (transform.position.z > 101)
        {
            if (transform.position.x > 11)
            {
                transform.position = new Vector3(11, transform.position.y, transform.position.z);
            }
            if (transform.position.x < -11)
            {
                transform.position = new Vector3(-11, transform.position.y, transform.position.z);
            }
            if (transform.position.y > 4)
            {
                transform.position = new Vector3(transform.position.x, 4, transform.position.z);
            }
            if (transform.position.y < -4)
            {
                transform.position = new Vector3(transform.position.x, -4, transform.position.z);
            }
        }
    }
    public void Damage()
    {
        HP -= 1;
        if (HP < 1)
        {
            SceneManager.LoadScene(8);
        }
    }
    public void Death_Damage()
    {
        HP -= 5;
        if (HP < 1)
        {
            SceneManager.LoadScene(8);
        }
    }
    void Movement()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(Horizontal, Vertical, 0) * Time.deltaTime * _speed);
    }
    public void Col_1()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 107);
    }
    public void Col_2()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 100);
    }
}