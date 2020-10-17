using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class zombieLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 3;
    public float leapForce = -35;
    private Unit unitCalcs;
    public Rigidbody2D rb2D; // { get; set; }

    void Start()
    {
        unitCalcs = gameObject.GetComponent<Unit>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (unitCalcs.dist <= 2)
        {
            Leap();
        }
    }
    private void Leap()
    {
        rb2D.AddForce(unitCalcs.pathDirection * leapForce * Time.deltaTime, ForceMode2D.Force);
        //rb2D.velocity = unitCalcs.target.position * (unitCalcs.speed * Time.deltaTime);
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

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerUnitLogic>().health--;
            print(collision.gameObject.GetComponent<PlayerUnitLogic>().health);
        }
    }
}
