using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public OpenDoor buttonPressScript;
    // Start is called before the first frame update
    private Vector2 initialPosition = new Vector2(0, 0);
    private Vector2 activatedPosition = new Vector2(0, 0);
    public float openSpeed = 20f;
    public float closeSpeed = 10f;
    public Vector2 doorMovementDirection = new Vector2(0, 0);
    public AudioSource audioSource;
    bool doorOpening = true;


    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        initialPosition = transform.position;
        activatedPosition = initialPosition - doorMovementDirection;


    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressScript.buttonActivated == true)
        {
 

            transform.position = Vector2.MoveTowards(transform.position, activatedPosition, openSpeed * Time.deltaTime);

            if (doorOpening == true)
            {
                audioSource.Play();
                doorOpening = false;
            }


        }

        if (buttonPressScript.buttonActivated == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, initialPosition, closeSpeed * Time.deltaTime);
            doorOpening = true;
        }
    }
}
