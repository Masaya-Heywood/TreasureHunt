using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private float playerXPosition = 0f;
    private float playerYPosition = 0f;
    private float currentZ = 0f;
    Vector3 offset;
    public GameObject playerCharacter;


    void Start()
    {
        currentZ = transform.position.z;
        offset = transform.position - playerCharacter.transform.position;
    }

    // Follows the player's location without rotating
    void Update()
    {
        playerXPosition = playerCharacter.transform.position.x - offset.x;
        playerYPosition = playerCharacter.transform.position.y - offset.y;
        Vector3 playerLocation = new Vector3(playerXPosition, playerYPosition, currentZ);

        transform.position = playerLocation;
    }
}
