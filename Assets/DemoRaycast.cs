using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoRaycast : MonoBehaviour
{
    public float raycastDistance = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray2D myRay = new Ray2D(transform.position, transform.up);

        Debug.DrawRay(myRay.origin, myRay.direction * raycastDistance, Color.white);


    }
}
