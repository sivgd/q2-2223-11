using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogfor2 : MonoBehaviour
{
    public int dia = 0;
    public GameObject Dialog;
    public GameObject DarkDialog;
    public Text nameText;
    public Text DialogText;

    private Queue<string> sentances;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.IsInDialog = 0;
        Dialog.SetActive(false);
        DarkDialog.SetActive(false);
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
        if (sentances.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentance = sentances.Dequeue();
        DialogText.text = sentance;
        PauseGame();
    }

    void EndDialog()
    {
        Debug.Log("ENd of conversation");
    }

    public void PauseGame()
    {
        Dialog.SetActive(true);
        dia = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (dia == 1)
            {
                UnPauseGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void UnPauseGame()
    {
        Dialog.SetActive(false);
        dia = 0;
    }
}
