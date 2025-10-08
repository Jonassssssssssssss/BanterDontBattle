using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class DialogueButtons : MonoBehaviour
{
    public enum Undertones { Happy, Sad, Insulting, Uplifting, Nonsense, Mad };
    public Undertones Undertone;

    public string _message = "New message";
    [SerializeField] TextMeshProUGUI _dialogueBubbleText;
    [SerializeField] TextMeshProUGUI _buttonText;
    CombatManager CM;
    [SerializeField] GameObject _speachBubble;

    public delegate void SelectedOption();
    public static event SelectedOption selectedOption;

    bool DontDestroyOnSpawn;

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

    public void ShowText()
    {
        _buttonText.text = _message;
    }

    public void SelectOption()
    {
        StartCoroutine(selectedoption());
    }

    IEnumerator selectedoption()
    {
        GameObject bubble = Instantiate(_speachBubble, transform.position, Quaternion.identity);
        bubble.transform.SetParent(GameObject.Find("Speach bubble position").GetComponent<Transform>());
        bubble.transform.localPosition = Vector3.zero;
        bubble.GetComponent<SpeachBubble>().SetText(_message);

        DontDestroyOnSpawn = true;
        selectedOption();

        yield return new WaitForSeconds(2f);

        selectedOption();
    }
}
