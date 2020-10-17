using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool buttonActivated = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        buttonActivated = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        buttonActivated = false;
    }

}
