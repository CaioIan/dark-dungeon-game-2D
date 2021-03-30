using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMngr : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject enemy;

    public static SpawnMngr instance;



    // Start is called before the first frame update
    void Start()
    {
        //Primeiro float Tempo que vai demorar pra nascer o bicho no inicio do jogo
        //Segundo float de quanto em quanto tempo vai demorar pra nascer

        InvokeRepeating("SpawnEnemies",5f, 4f);

        instance = this;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemies()

    {
        int Index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[Index].position, Quaternion.identity);


    }
}