using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public SpriteRenderer thisSprite;
    public Rigidbody2D rb2D;
    private Vector2 mousePosition = new Vector2(0, 0);
    public float speed = 10f;
    public float groundGravity = 1f;
    public float airGravity = 7f;
    private bool movement = false;

    //private Vector2 playerPosition = new Vector2(transform.position.x, transform.position.y);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Input
        if (Input.GetMouseButton(1))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }


        //Movement Execution

        if ((Vector2)transform.position != mousePosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
            //transform.position = Vector2.Lerp(transform.position, mousePosition, Time.deltaTime);
            //rb2D.AddForce(transform.position * speed * Time.deltaTime, ForceMode2D.Impulse);
            //transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
            movement = true;
        }
    }

    //Movement Execution
    //void FixedUpdate()
    //{
    //    rb2D.AddForce(transform.position * (force * Time.deltaTime));
    //}
}
