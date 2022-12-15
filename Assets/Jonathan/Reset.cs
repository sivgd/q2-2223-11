using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public FadeScreen fadeScreen;

    public void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            StartCoroutine(ResetScene());
        }
    }

    IEnumerator ResetScene()
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
