using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    public void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
