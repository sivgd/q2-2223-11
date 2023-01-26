using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pain : MonoBehaviour
{
    private Animator a;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.internalscreaming = 0;
        GameManager.onramp = 0;
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.internalscreaming == 1)
        {
            a.SetBool("Wall", true);
        }
        if (GameManager.internalscreaming == 0)
        {
            a.SetBool("Wall", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            a.SetBool("Slide", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            a.SetBool("Slide", false);
        }
    }
}
