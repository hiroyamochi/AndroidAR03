using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;

    public Transform rangeA;

    public Transform rangeB;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(4);

        for(int i = 0; i < 3; i++){
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            float z = Random.Range(rangeA.position.z, rangeB.position.z);
            Instantiate(balloons[i], new Vector3(x, y, z), Quaternion.identity);
            // Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }
}
