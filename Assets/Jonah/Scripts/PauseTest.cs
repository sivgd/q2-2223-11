using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTest : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public SceneSwitch SS;


    // Update is called once per frame
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
    }

    void Pausing()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
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
