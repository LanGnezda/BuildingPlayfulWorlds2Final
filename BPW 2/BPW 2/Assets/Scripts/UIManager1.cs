using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager1 : MonoBehaviour {

    [SerializeField] private Image pausePanel;
    private bool ScreenActive;
    void Start()
    {
        pausePanel.enabled = false;
        ScreenActive = false;
    }
    void Update()
    {
        CallPause();
    }


    void CallPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ScreenActive == false)
            {
                PauseGame();
            }
            else if (ScreenActive == true)
            {
                ContinueGame();
            }
        }
    }



    private void PauseGame()
    {
        ScreenActive = true;
        Time.timeScale = 0;
        pausePanel.enabled = true;
        //Disable scripts that still work while timescale is set to 0
    }


    private void ContinueGame()
    {
        ScreenActive = false;
        Time.timeScale = 1;
        pausePanel.enabled = false;
        //enable the scripts again
    }
}
