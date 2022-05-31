using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grass_Spawner_Scr : MonoBehaviour
{
    public GameObject Grass;
    public int Grass_Time = 1;
    void Start()
    {
        StartCoroutine("SpawnGrass");
    }
    IEnumerator SpawnGrass()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(Grass_Time);
            Instantiate(Grass, new Vector3(Random.Range(-17f, 17f), 15, 100), Quaternion.identity);
        }
    }
}