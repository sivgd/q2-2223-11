using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNextSentace : MonoBehaviour
{
    public GameObject Dialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<DialogManager>().DisplayNextSentence();
        Dialog.SetActive(false);
    }
}
