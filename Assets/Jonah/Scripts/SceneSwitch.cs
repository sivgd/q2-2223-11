using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private int Home = 0;
    private int Start = 1;
    private int Credit = 2;
    private int Options = 3;
    public void OnButtonPress()
    {
        SceneManager.LoadScene(Start);
    }

    public void OnButtonPress2()
    {
        SceneManager.LoadScene(Credit);
    }

    public void OnButtonPress3()
    {
        SceneManager.LoadScene(Options);
    }
    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void OnButtonPress4()
    {
        SceneManager.LoadScene(Home);
    }
}
