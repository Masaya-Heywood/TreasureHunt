using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWarpScript : MonoBehaviour
{
    // Start is called before the first frame update
    public warpSpawn spawn;
    public bool warping = false; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawn.warp = true;
        warping = true;
    }
}
