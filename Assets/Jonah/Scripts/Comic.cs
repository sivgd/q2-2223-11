using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comic : MonoBehaviour
{
    public GameObject[] ComicPanels;
    private int currentPanel = 0;
    private int timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        ComicPanels[0].SetActive(false);
        ComicPanels[1].SetActive(false);
        ComicPanels[2].SetActive(false);
        ComicPanels[3].SetActive(false);
        ComicPanels[4].SetActive(false);
        ComicPanels[5].SetActive(false);
        ComicPanels[6].SetActive(false);
        ComicPanels[7].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && timer == 1 && currentPanel <10)
        {
            currentPanel++;
            timer = 0;
        }
        if (Input.GetMouseButtonUp(0))
        {
            timer = 1;
        }
        if (currentPanel == 1)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(false);
            ComicPanels[2].SetActive(false);
            ComicPanels[3].SetActive(false);
            ComicPanels[4].SetActive(false);
            ComicPanels[5].SetActive(false);
            ComicPanels[6].SetActive(false);
            ComicPanels[7].SetActive(false);
        }
        if (currentPanel == 2)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(true);
            ComicPanels[2].SetActive(false);
            ComicPanels[3].SetActive(false);
            ComicPanels[4].SetActive(false);
            ComicPanels[5].SetActive(false);
            ComicPanels[6].SetActive(false);
            ComicPanels[7].SetActive(false);
        }
        if (currentPanel == 3)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(true);
            ComicPanels[2].SetActive(true);
            ComicPanels[3].SetActive(false);
            ComicPanels[4].SetActive(false);
            ComicPanels[5].SetActive(false);
            ComicPanels[6].SetActive(false);
            ComicPanels[7].SetActive(false);
        }
        if (currentPanel == 4)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(true);
            ComicPanels[2].SetActive(true);
            ComicPanels[3].SetActive(true);
            ComicPanels[4].SetActive(false);
            ComicPanels[5].SetActive(false);
            ComicPanels[6].SetActive(false);
            ComicPanels[7].SetActive(false);
        }
        if (currentPanel == 5)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(true);
            ComicPanels[2].SetActive(true);
            ComicPanels[3].SetActive(true);
            ComicPanels[4].SetActive(true);
            ComicPanels[5].SetActive(false);
            ComicPanels[6].SetActive(false);
            ComicPanels[7].SetActive(false);
        }
        if (currentPanel == 6)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(true);
            ComicPanels[2].SetActive(true);
            ComicPanels[3].SetActive(true);
            ComicPanels[4].SetActive(true);
            ComicPanels[5].SetActive(true);
            ComicPanels[6].SetActive(false);
            ComicPanels[7].SetActive(false);
        }
        if (currentPanel == 7)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(true);
            ComicPanels[2].SetActive(true);
            ComicPanels[3].SetActive(true);
            ComicPanels[4].SetActive(true);
            ComicPanels[5].SetActive(true);
            ComicPanels[6].SetActive(true);
            ComicPanels[7].SetActive(false);
        }
        if (currentPanel == 8)
        {
            ComicPanels[0].SetActive(true);
            ComicPanels[1].SetActive(true);
            ComicPanels[2].SetActive(true);
            ComicPanels[3].SetActive(true);
            ComicPanels[4].SetActive(true);
            ComicPanels[5].SetActive(true);
            ComicPanels[6].SetActive(true);
            ComicPanels[7].SetActive(true);
        }
        if (currentPanel == 9)
        {
            SceneManager.LoadScene(10);
        }
    }
}
