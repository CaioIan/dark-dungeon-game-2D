using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float vel;

    public ParticleSystem effect;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * vel);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Instantiate(effect, transform.position, transform.rotation);
           
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(effect, transform.position, transform.rotation);
            
            Destroy(gameObject);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "saw")
        {
            Instantiate(effect, transform.position, transform.rotation);

            Destroy(gameObject);
        }

        
    }
}
