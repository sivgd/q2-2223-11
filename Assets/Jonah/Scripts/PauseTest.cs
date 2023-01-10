using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTest : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public SceneSwitch SS;
    

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
        StartCoroutine(resumer());
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pausing()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ToMenu()
    {
        Time.timeScale = 1f;
        SS.OnButtonPress4();
    }

    IEnumerator resumer()
    {
        yield return new WaitForSeconds(0.5f);
        pauseMenuUI.SetActive(false);

    }


}
