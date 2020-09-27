using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpSpawn : MonoBehaviour
{
    public GameObject playerCharacter;
    public bool warp = false;
    // Start is called before the first frame update
    void Start()
    {
        //playerCharacter = GameObject.Find("obj_PlayerCharacter");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (warp == true)
        {
            playerCharacter.transform.position = transform.position;
            warp = false;
        }
    }
}
