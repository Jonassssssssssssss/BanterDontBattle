using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class DialogueButtons : MonoBehaviour
{
    [SerializeField] string _message = "New message";
    [SerializeField] TextMeshProUGUI _dialogueBubbleText;
    CombatManager CM;

    public void ShowText()
    {
        _dialogueBubbleText.text = _message;
    }
}
