using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsController : MonoBehaviour
{
    public Text pointsNumDrag;
    public int points;

    public void addPoints()
    {
        points++;
        pointsNumDrag.text = points.ToString();

        if (points == 10)
        {
            SceneManager.LoadScene(1);
        }
    }
}
