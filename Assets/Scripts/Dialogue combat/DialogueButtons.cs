using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class DialogueButtons : MonoBehaviour
{
    public string _message = "New message";
    [SerializeField] TextMeshProUGUI _dialogueBubbleText;
    [SerializeField] TextMeshProUGUI _buttonText;
    CombatManager CM;

    public void ShowText()
    {
        //_dialogueBubbleText.text = _message;
        _buttonText.text = _message;
    }
}
