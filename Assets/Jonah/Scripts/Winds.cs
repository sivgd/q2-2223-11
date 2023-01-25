using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winds : MonoBehaviour
{
    private Animator a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.wind == 1)
        {
            a.SetBool("Speed", true);
        }
        else if (GameManager.wind == 0)
        {
            a.SetBool("Speed", false);
        }

    }
}
