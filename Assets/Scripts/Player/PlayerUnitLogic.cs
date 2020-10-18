using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitLogic : MonoBehaviour
{
    public float health = 5;
    public GameObject currentWarp;
    private CharacterMovement movement;
    public float maxHealth = 5;
    void Start()
    {
        movement = gameObject.GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            transform.position = currentWarp.transform.position; // warp back to current warp if dead
            gameObject.GetComponent<CharacterMovement>().mousePosition = transform.position;
            health = 10;
        }

        if (health > maxHealth)
        {
            health = 5;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.GetComponent<warpSpawn>().warpInactive == true)
        //{
        //    currentWarp.GetComponent<warpSpawn>().warpInactive = true; //set previous warp to inactive

        //    currentWarp = collision.gameObject; // set current warp to active
        //    currentWarp.GetComponent<warpSpawn>().warpInactive = false;
        //}
    }
}
