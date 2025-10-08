using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class SpeachBubble : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    public void SetText(string text)
    {
        _text.text = text;
    }
}
