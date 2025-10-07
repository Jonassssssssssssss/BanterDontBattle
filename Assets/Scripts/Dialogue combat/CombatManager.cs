using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public int ProgressionPoints;

    [SerializeField] GameObject[] ProgressionPointVisuals;

    OpponentDialogue OD;

    void Start()
    {
        OD = GameObject.Find("Lars").GetComponent<OpponentDialogue>();

        OD.NewDialaogue();
    }

    void Update()
    {
        if (ProgressionPoints == 5) Victory();

        if (Input.GetKeyDown("x")) ProgressionPoints++;
        if (Input.GetKeyDown("z")) ProgressionPoints--;

        UpdateProgressionPointVisuals();
    }

    void Victory()
    {
        Debug.LogError("You Win");
    }

    void UpdateProgressionPointVisuals()
    {
        foreach (GameObject O in ProgressionPointVisuals)
        {
            O.SetActive(false);
        }

        if (ProgressionPoints >= 1) ProgressionPointVisuals[0].SetActive(true);

        if (ProgressionPoints >= 2) ProgressionPointVisuals[1].SetActive(true);

        if (ProgressionPoints >= 3) ProgressionPointVisuals[2].SetActive(true);

        if (ProgressionPoints >= 4) ProgressionPointVisuals[3].SetActive(true);

        if (ProgressionPoints >= 5) ProgressionPointVisuals[4].SetActive(true);
    }

    public void PlayerHasMadeDecision()
    {
        OD.NewDialaogue();
    }
}
