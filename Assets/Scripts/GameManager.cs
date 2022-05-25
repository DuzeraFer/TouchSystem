using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject InputSystem;
    public GameObject DragAndDropSystem;
    public GameObject DragAndDropSystemCanvas;
    public GameObject WinPanel;

    private void Start()
    {
        NextPhase(1);
    }

    public void NextPhase(int Phase)
    {
        switch (Phase)
        {
            default:
                break;
            case 1:
                InputSystem.SetActive(true);
                WinPanel.SetActive(false);
                DragAndDropSystem.SetActive(false);
                DragAndDropSystemCanvas.SetActive(false);
                break;
            case 2:
                InputSystem.SetActive(true);
                WinPanel.SetActive(true);
                DragAndDropSystem.SetActive(false);
                DragAndDropSystemCanvas.SetActive(false);
                Time.timeScale = 0;
                break;
            case 3:
                InputSystem.SetActive(false);
                WinPanel.SetActive(false);
                DragAndDropSystem.SetActive(true);
                DragAndDropSystemCanvas.SetActive(true);
                Time.timeScale = 1;
                break;
        }
    }
}
