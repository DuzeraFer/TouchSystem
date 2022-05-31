using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCanvasController : MonoBehaviour
{
    public void playAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
