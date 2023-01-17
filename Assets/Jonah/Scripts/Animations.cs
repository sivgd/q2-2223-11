using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator a;


    public void Start()
    {
        a = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider Collision)
    {
       if(Collision.gameObject.tag == ("wall")) 
        {
            Debug.Log("test");
            a.SetBool("Wall", true);
        }
        else
        {
            a.SetBool("Wall", false);
        }
    }
}
