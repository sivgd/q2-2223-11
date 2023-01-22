using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(18.75f);
        SceneManager.LoadScene(4);
    }
}
