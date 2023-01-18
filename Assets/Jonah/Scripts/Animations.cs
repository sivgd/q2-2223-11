using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public int toramp = 0;

    public void Start()
    {

    }
    public void Update()
    {
        if(toramp == 1 && Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameManager.onramp = 1;
        }
        else if(toramp == 0 || Input.GetKeyUp(KeyCode.LeftControl))
        {
            GameManager.onramp = 0;
        }
    }

    public void OnTriggerEnter(Collider Collision)
    {
       if(Collision.gameObject.tag == "wall") 
        {
            GameManager.internalscreaming = 1;
        }
        if ( Collision.gameObject.tag == "ramp")
        {
            toramp = 1;
        }
    }
    public void OnTriggerExit(Collider other)
    {
            GameManager.internalscreaming = 0;
            toramp = 0;
    }


    //GAMER MOMENT THROBBY LIVES
}
