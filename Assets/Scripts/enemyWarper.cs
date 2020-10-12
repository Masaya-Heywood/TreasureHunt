using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWarper : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 6f;
    public Vector2 playerPosition = new Vector2(0, 0);
    public Vector2 initialPosition = new Vector2(0, 0);
    public GameObject playerCharacter;
    public AggroScript aggroRange;
    public warpSpawn spawn;
    public EnemyWarpScript enemyWarp;


    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = playerCharacter.transform.position;
        if (aggroRange.aggroed == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        }

        if (enemyWarp.warping == true)
        {
            transform.position = initialPosition;
            enemyWarp.warping = false; 
        }
    }
}
