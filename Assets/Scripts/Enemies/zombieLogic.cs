using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // if collision has tag "projectile", get hurt and reduce projectile durability
        if (collision.gameObject.CompareTag("Projectile"))
        {
            health -= collision.gameObject.GetComponent<ProjectileLogic>().projDmg;
            --collision.gameObject.GetComponent<ProjectileLogic>().projDura;

            //destroy projectile if it has no durability left
            if (collision.gameObject.GetComponent<ProjectileLogic>().projDura <= 0)
            {
                Destroy(collision.gameObject);
            }

            //die if health is 0
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
