using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 initialPosition = new Vector2(0, 0);
    private Vector2 activatedPosition = new Vector2(0, 0);
    private Vector2 currentPosition = new Vector2(0, 0);
    private bool atLeft = false;
    private bool atRight = true;
    public Vector2 leftMovementDirection = new Vector2(0, 0);
    public float speed = 20f;


    void Start()
    {
        initialPosition = transform.position;
        activatedPosition = initialPosition - leftMovementDirection;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        if (currentPosition == activatedPosition)
        {
            atLeft = true;
            atRight = false;
        }

        if (currentPosition == initialPosition)
        {
            atLeft = false;
            atRight = true;
        }



        if (atLeft == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, initialPosition, speed * Time.deltaTime);
        }

        if (atRight == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, activatedPosition, speed * Time.deltaTime);
        }
    }
}
