using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy_Car_Spawner_Scr : MonoBehaviour
{
    public GameObject Enemy_Car;
    public int Enemy_Time = 2;
    void Start()
    {
        StartCoroutine("SpawnEnemyCar");
    }
    IEnumerator SpawnEnemyCar()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(Enemy_Time);
            Instantiate(Enemy_Car, new Vector3(Random.Range(-10f, 10f), 15, 107), Quaternion.identity);
        }
    }
}