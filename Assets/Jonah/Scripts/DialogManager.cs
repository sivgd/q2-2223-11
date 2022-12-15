using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public Text nameText;
    public Text DialogText;

    private Queue<string> sentances;
    // Start is called before the first frame update
    void Start()
    {
        sentances = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        nameText.text = dialog.name;

        sentances.Clear();

        foreach (string sentace in dialog.sentances)
        {
            sentances.Enqueue(sentace);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentances.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentance =sentances.Dequeue();
        DialogText.text = sentance;
    }

    void EndDialog()
    {
        Debug.Log("ENd of conversation");
    }
}
