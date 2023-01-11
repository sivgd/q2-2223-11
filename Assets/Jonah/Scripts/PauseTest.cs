using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTest : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public SceneSwitch SS;
    public int pause = 0;
    public GameObject Dialog;

    // Update is calaled once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pausing();
            }
        }

    }
    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pause = 0;
        Dialog.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    void Pausing()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pause = 1;
        Dialog.SetActive(false);
    }

    public void ToMenu()
    {
        Time.timeScale = 1f;
        SS.OnButtonPress4();
    }

}
