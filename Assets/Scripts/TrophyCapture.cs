using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyCapture : MonoBehaviour
{
    // Start is called before the first frame update
    public ControllerScript controller;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.trophyScore++;
        Destroy(gameObject);
    }
}
