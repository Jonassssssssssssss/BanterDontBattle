using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AnswerOptions
{
    public string Message;
    public enum Undertones { Happy, Sad, Insulting};
    public Undertones Undertone;
}

[System.Serializable]
public class DialogueOptions
{
    public string Message;
    public enum Undertones { Happy, Sad, Insulting};
    public Undertones Undertone;

    public AnswerOptions[] AnswerOptions;
}

public class OpponentDialogue : MonoBehaviour
{
    [SerializeField] DialogueOptions[] _dialogueOptions;
    [SerializeField] GameObject _optionsButtons;
    [SerializeField] Transform[] _optionsButtonsPositions;

    void Update()
    {
        if (Input.GetKeyDown("f")) NewDialaogue();
    }

    public void NewDialaogue()
    {
        StartCoroutine(newDialaogue());
    }

    IEnumerator newDialaogue()
    {
        int pickDialogue = Random.Range(0, _dialogueOptions.Length);
        DialogueOptions DO = _dialogueOptions[pickDialogue];

        yield return new WaitForSeconds(3f);

        for (int i = 0; i < 3; i++)
        {
            GameObject button = Instantiate(_optionsButtons, transform.position, Quaternion.identity);
            button.transform.SetParent(_optionsButtonsPositions[i]);
            button.transform.localPosition = Vector3.zero;

            DialogueButtons D = button.GetComponent<DialogueButtons>();
            D._message = DO.AnswerOptions[i].Message;
            D.ShowText();
        }
    }
}
