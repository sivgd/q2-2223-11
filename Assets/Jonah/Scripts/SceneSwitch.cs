using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int n;
    public void OnButtonPress()
    {
        SceneManager.LoadScene(n);
    }
}
