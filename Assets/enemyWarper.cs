using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWarper : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 6f;
    public Vector2 playerPosition = new Vector2(0, 0);
    public GameObject playerCharacter;
    public GameObject aggroRange;
    public warpSpawn spawn;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
