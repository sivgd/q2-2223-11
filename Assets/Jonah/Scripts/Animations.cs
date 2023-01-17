using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{


    public void Start()
    {
    }

    private void OnTriggerEnter(Collider Collision)
    {
       if(Collision.gameObject.tag == "wall") 
        {
            GameManager.internalscreaming = 1;
        }
        if (Collision.gameObject.tag == "ramp" && Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameManager.onramp = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
            GameManager.internalscreaming = 0;
        GameManager.onramp = 0;
    }


    //GAMER MOMENT THROBBY LIVES
}
