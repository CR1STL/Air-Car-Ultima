using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fly_Collider_2 : MonoBehaviour
{
        void OnTriggerStay(Collider other)
        {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    GameObject.Find("Player Car").GetComponent<Player_Control_Scr>().Col_2();
                }
        }
}