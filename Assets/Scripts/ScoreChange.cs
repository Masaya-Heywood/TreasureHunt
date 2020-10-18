using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    public Text score;
    public ControllerScript controller;
    private GameObject playerCharacter;
    private PlayerUnitLogic player;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        playerCharacter = GameObject.Find("obj_PlayerCharacter");
        player = playerCharacter.GetComponent<PlayerUnitLogic>();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = string.Format("Treasure: {0}/3" + "\n" + "Health: {1}/5", controller.trophyScore, player.health);
    }
}
