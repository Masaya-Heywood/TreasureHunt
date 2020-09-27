using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWarp : MonoBehaviour
{
    public warpSpawn spawn;
    // Start is called before the first frame update
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
    }
}
