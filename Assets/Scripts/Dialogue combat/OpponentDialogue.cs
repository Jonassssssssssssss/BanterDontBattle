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
}
