using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private int Start = 1;
    private int Credit = 2;
    public void OnButtonPress()
    {
        SceneManager.LoadScene(Start);
    }

    public void OnButtonPress2()
    {
        SceneManager.LoadScene(Credit);
    }
}
