using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fly_Collider_1 : MonoBehaviour
{
        void OnTriggerStay(Collider other)
        {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    GameObject.Find("Player Car").GetComponent<Player_Control_Scr>().Col_1();
                }
        }
}