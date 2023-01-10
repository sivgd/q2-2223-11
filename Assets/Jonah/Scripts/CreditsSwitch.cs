using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsSwitch : MonoBehaviour
{
    public GameObject[] Credits;

    private void Start()
    {
        Credits[0].SetActive(true);
        Credits[1].SetActive(false);
        Credits[2].SetActive(false);
        Credits[3].SetActive(false);
        Credits[4].SetActive(false);
        Credits[5].SetActive(false);
        Credits[6].SetActive(false);
        Credits[7].SetActive(false);
    }

    public void Alan()
    {
        Credits[0].SetActive(false);
        Credits[1].SetActive(true);
        Credits[2].SetActive(false);
        Credits[3].SetActive(false);
        Credits[4].SetActive(false);
        Credits[5].SetActive(false);
        Credits[6].SetActive(false);
        Credits[7].SetActive(false);
    }

    public void Ayla()
    {
        Credits[0].SetActive(false);
        Credits[1].SetActive(false);
        Credits[2].SetActive(true);
        Credits[3].SetActive(false);
        Credits[4].SetActive(false);
        Credits[5].SetActive(false);
        Credits[6].SetActive(false);
        Credits[7].SetActive(false);
    }

    public void Isabella()
    {
        Credits[0].SetActive(false);
        Credits[1].SetActive(false);
        Credits[2].SetActive(false);
        Credits[3].SetActive(true);
        Credits[4].SetActive(false);
        Credits[5].SetActive(false);
        Credits[6].SetActive(false);
        Credits[7].SetActive(false);
    }

    public void Casey()
    {
        Credits[0].SetActive(false);
        Credits[1].SetActive(false);
        Credits[2].SetActive(false);
        Credits[3].SetActive(false);
        Credits[4].SetActive(true);
        Credits[5].SetActive(false);
        Credits[6].SetActive(false);
        Credits[7].SetActive(false);
    }

    public void Jonah()
    {
        Credits[0].SetActive(false);
        Credits[1].SetActive(false);
        Credits[2].SetActive(false);
        Credits[3].SetActive(false);
        Credits[4].SetActive(false);
        Credits[5].SetActive(true);
        Credits[6].SetActive(false);
        Credits[7].SetActive(false);
    }

    public void Jonathan()
    {
        Credits[0].SetActive(false);
        Credits[1].SetActive(false);
        Credits[2].SetActive(false);
        Credits[3].SetActive(false);
        Credits[4].SetActive(false);
        Credits[5].SetActive(false);
        Credits[6].SetActive(true);
        Credits[7].SetActive(false);
    }

    public void Tayton()
    {
        Credits[0].SetActive(false);
        Credits[1].SetActive(false);
        Credits[2].SetActive(false);
        Credits[3].SetActive(false);
        Credits[4].SetActive(false);
        Credits[5].SetActive(false);
        Credits[6].SetActive(false);
        Credits[7].SetActive(true);
    }
}
