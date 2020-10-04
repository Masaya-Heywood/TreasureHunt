using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBulletScript : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public Rigidbody2D rb2DBullet;
    //public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();

            Rigidbody2D bullet = Instantiate(rb2DBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;

            bullet.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);

             //coolDown = Time.time + attackSpeed;
         }
     }
 }

