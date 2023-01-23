using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private int Home = 1;
    private int Start = 2;
    private int Credit = 3;
    private int Options = 4;
    private int LevelOne = 5;
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
    public void OnButtonPress5()
    {
        SceneManager.LoadScene(LevelOne);
    }
    public void OnButtonPress6()
    {
        SceneManager.LoadScene(6);
    }
    public void OnButtonPress7()
    {
        SceneManager.LoadScene(7);
    }
    public void OnButtonPress8()
    {
        SceneManager.LoadScene(8);
    }
    public void OnButtonPress9()
    {
        SceneManager.LoadScene(9);
    }
}
