using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    public Transform[] FireSpawn;

    public GameObject Fire;

    public static FireManager inst;

   



    // Start is called before the first frame update
    void Start()
    {
        //Primeiro float Tempo que vai demorar pra nascer o bicho no inicio do jogo
        //Segundo float de quanto em quanto tempo vai demorar pra nascer

        InvokeRepeating("SpawnEnemies", 4f, 2f);

        inst = this;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemies()

    {
        int Index = Random.Range(0, FireSpawn.Length);
        Instantiate(Fire, FireSpawn[Index].position, Quaternion.identity);


    }
}
