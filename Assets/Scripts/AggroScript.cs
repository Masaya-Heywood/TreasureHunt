using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AggroScript : MonoBehaviour
{
    public GameObject playerCharacter;
    public bool aggroed = false;
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
        aggroed = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        aggroed = false;

    }
}
