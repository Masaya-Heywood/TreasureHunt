using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public SpriteRenderer thisSprite;
    public Rigidbody2D rb2D;
    private Vector2 mousePosition = new Vector2(0, 0);
    private Vector3 constantmousePosition = new Vector2(0, 0);
    public float speed = 10f;
    public float groundGravity = 1f;
    public float airGravity = 7f;
    //private bool movement = false;

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

            Vector3 dir = (constantmousePosition - transform.position).normalized;
            Debug.Log(dir);
            rb2D.AddForce(dir * speed);
        }


        //Movement Execution

        //if ((Vector2)transform.position != mousePosition)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
        //    //transform.position = Vector2.Lerp(transform.position, mousePosition, Time.deltaTime);
        //    //rb2D.AddForce(transform.position * speed * Time.deltaTime, ForceMode2D.Impulse);
        //    //transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
        //    //movement = true;
        //}



        //Rotation

        constantmousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 diff = constantmousePosition - transform.position;
        diff.Normalize();

        float RotationZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, RotationZ - 90);

        //Movement




        //Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        //lookPos = lookPos - transform.position;
        //float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //cameraDif = camera.transform.position.y - fpc.transform.position.y;

        //Vector3 constantMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //constantMousePosition.Normalize();

        //float rotZ = Mathf.Atan2(constantMousePosition.y, constantMousePosition.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(0f, 0f, rotZ + 0);

        //if (constantMousePosition.x >= 0)
        //{
        //    transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        //}
        //else
        //{
        //    transform.rotation = Quaternion.Euler(0f, 0f, rotZ + 180);
        //}


    }

    //Movement Execution
    //void FixedUpdate()
    //{
    //    rb2D.AddForce(transform.position * (force * Time.deltaTime));
    //}
}
