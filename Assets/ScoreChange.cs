using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    public Text score;
    public ControllerScript controller;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = string.Format("Treasure: {0}/4", controller.trophyScore);
    }
}
