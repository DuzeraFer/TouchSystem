using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumGen : MonoBehaviour
{
    Text NumberText;
    [HideInInspector] public int number;
    int lastNumber;
    public int maxNumber;

    private void Start()
    {
        NumberText = GetComponent<Text>();

        generateNum();
    }

    public void generateNum()
    {
        while (number == lastNumber)
        {
            number = Random.Range(1, maxNumber);
        }

        lastNumber = number;

        NumberText.text = number.ToString();
    }
}
