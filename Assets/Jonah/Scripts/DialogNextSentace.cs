using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNextSentace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<DialogManager>().DisplayNextSentence();
    }
}
