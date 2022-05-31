using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Car_Wall_Spawner_Scr : MonoBehaviour
{
    public GameObject Car_Wall;
    public int Car_Wall_Time = 1;
    void Start()
    {
        StartCoroutine("SpawnCarWall");
    }
    IEnumerator SpawnCarWall()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(Car_Wall_Time);
            Instantiate(Car_Wall, new Vector3(0, 15, 107), Quaternion.identity);
        }
    }
}