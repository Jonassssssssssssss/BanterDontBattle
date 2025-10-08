using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class SpeachBubble : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    public bool DontDestroyOnSpawn = true;

    void OnEnable()
    {
        DialogueButtons.selectedOption += SelectResponse;
    }

    void OnDisable()
    {
        DialogueButtons.selectedOption -= SelectResponse;
    }

    void SelectResponse()
    {
        if (!DontDestroyOnSpawn) Destroy(gameObject);
        else DontDestroyOnSpawn = false;
    }

    public void SetText(string text)
    {
        _text.text = text;
    }
}
