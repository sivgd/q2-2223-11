using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger2 : MonoBehaviour
{
    public Dialog dialog;

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogfor2>().StartDialog(dialog);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Dialogfor2>().StartDialog(dialog);
    }
}
