using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputSystem : MonoBehaviour
{
    public GameManager gameManager;

    public Text pointsText;
    public int points;

    public GameObject numberGenerator;
    RandomNumGen randomNumGen;

    private void Start()
    {
        points = 0;
        pointsText.text = "0";
        randomNumGen = numberGenerator.GetComponent<RandomNumGen>();
    }

    private void Update()
    {
        if (Input.touchCount == randomNumGen.number)
        {
            randomNumGen.generateNum();
            points++;
            pointsText.text = points.ToString();

            if (points == 10)
            {
                gameManager.NextPhase(2);
            }
        }
    }
}
