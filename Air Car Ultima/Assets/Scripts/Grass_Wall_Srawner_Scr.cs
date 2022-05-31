using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grass_Wall_Srawner_Scr : MonoBehaviour
{
    public GameObject Grass_Wall;
    public int Grass_Wall_Time = 1;
    void Start()
    {
        StartCoroutine("GrassCarWall");
    }
    IEnumerator GrassCarWall()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(Grass_Wall_Time);
            Instantiate(Grass_Wall, new Vector3(0, 15, 100), Quaternion.identity);
        }
    }
}