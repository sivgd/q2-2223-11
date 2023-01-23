using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Sensitivity = 1;
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }
}
