using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpSpawn : MonoBehaviour
{
    public GameObject playerCharacter;
    public bool warpInactive = true;
    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = GameObject.Find("obj_PlayerCharacter");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == playerCharacter)
        {
            playerCharacter.GetComponent<PlayerUnitLogic>().currentWarp.GetComponent<warpSpawn>().warpInactive = true; //set previous warp to inactive, this doesn't look elegant

            playerCharacter.GetComponent<PlayerUnitLogic>().currentWarp = gameObject; // set current warp to active
            warpInactive = false;
        }
    }
}


