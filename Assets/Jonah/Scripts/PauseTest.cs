using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTest : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject DarkDialog;
    public SceneSwitch SS;
    public int pause = 0;
    public GameObject Dialog;
    public Dialogfor2 DiaManager;

    // Update is calaled once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && GameManager.IsInDialog == 0)
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
        pauseMenuUI.SetActive(false);
        DarkDialog.SetActive(false);
        if (DiaManager.dia == 1)
        {
        Dialog.SetActive(true);
        }
    }

    void Pausing()
    {
        DarkDialog.SetActive(true);
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
