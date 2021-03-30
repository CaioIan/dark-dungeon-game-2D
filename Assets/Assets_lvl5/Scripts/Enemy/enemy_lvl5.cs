using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_lvl5 : MonoBehaviour
{
    public float speed;
    GameObject Player;
    Animator anim;
    bool isAlive = true;
    public int score;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null && isAlive)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            anim.SetBool("die", true);
            Destroy(gameObject, 0.1f);
            Game_ctrl_5.instan.totalscore += score;
            Game_ctrl_5.instan.UpdateScoreText();
            Game_ctrl_5.instan.NextLevel();


        }




    }
}