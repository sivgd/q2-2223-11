using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogtrigger : MonoBehaviour
{
    public Dialog dialog;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
