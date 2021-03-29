using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScriptDown : MonoBehaviour
{
    public float speed;
    public float MoveTime;

    private bool dirTop = false;

    private float Timer;



    // Update is called once per frame
    void Update()
    {
        if (dirTop)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }



        Timer += Time.deltaTime;

        if (Timer >= MoveTime)
        {
            dirTop = !dirTop;
            Timer = 0f;
        }


    }
}
