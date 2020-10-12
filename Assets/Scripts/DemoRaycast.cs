using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoRaycast : MonoBehaviour
{
    public float raycastDistance = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray2D myRay = new Ray2D(transform.position, transform.up);
            RaycastHit2D rayHit = Physics2D.Raycast(myRay.origin, myRay.direction, raycastDistance);

            if (rayHit.collider != null)
            {
                if (rayHit.transform.gameObject.CompareTag("Enemy"))
                {
                    Destroy(rayHit.transform.gameObject);
                }
            }


            Debug.DrawRay(myRay.origin, myRay.direction * raycastDistance, Color.white);
        }


    }
}
