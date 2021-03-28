using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_lvl3 : MonoBehaviour
{
    public Rigidbody2D rig;
    public Animator anim;
    public float speed;

    public SpriteRenderer sprite;
    public string lvlName;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameCtrl_3.insta.ShowMenu();
            Time.timeScale = 0;


        }



    }



    void Move()
    {

        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        sprite.flipX = (mousePos.x < screenPoint.x);

        float x = (Input.GetAxis("Horizontal"));
        rig.velocity = new Vector2(x * speed, rig.velocity.y);

        if (x > 0)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (x < 0)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (x == 0)
        {
            anim.SetBool("walk", false);
        }


        float y = (Input.GetAxis("Vertical"));
        rig.velocity = new Vector2(rig.velocity.x, y * speed);

        if (y > 0)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (y < 0)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (y == 0)
        {
            anim.SetBool("walk", false);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Restart_lvl_3");

            Destroy(gameObject);

        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("saw"))
        {
            SceneManager.LoadScene("Restart_lvl_3");

            Destroy(gameObject);

        }
    }

}
