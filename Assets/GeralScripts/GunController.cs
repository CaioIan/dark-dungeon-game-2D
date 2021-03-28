using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    SpriteRenderer sprite;

    public GameObject bullet;

    public Transform spawnBullet;


    public float fireRate;

    float nextShoot;

    public AudioSource a_shot;

    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Aim();

        if (Input.GetMouseButton(0))
        {

            if (Time.time > nextShoot)
            {
                nextShoot = Time.time + 1 / fireRate;
                a_shot.Play();
                Shoot();
                
            }
            
        }

        

        
    }

    void Shoot()
    {
        
        Instantiate(bullet, spawnBullet.position, transform.rotation);
        

    }

    void Aim()
    {

        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 ofsset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);

        float angle = Mathf.Atan2(ofsset.y, ofsset.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        sprite.flipY = (mousePos.x < screenPoint.x);



    }

     
    

}