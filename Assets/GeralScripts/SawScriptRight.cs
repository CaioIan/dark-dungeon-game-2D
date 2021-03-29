using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScriptRight : MonoBehaviour
{
    public float speed;
    public float MoveTime;

    private bool dirLeft = false;

    private float Timer;



    // Update is called once per frame
    void Update()   
    {
        if (dirLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }



        Timer += Time.deltaTime;

        if (Timer >= MoveTime)
        {
            dirLeft = !dirLeft;
            Timer = 0f;
        }


    }
}
