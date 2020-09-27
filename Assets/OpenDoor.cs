using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool buttonActivated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        buttonActivated = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        buttonActivated = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
