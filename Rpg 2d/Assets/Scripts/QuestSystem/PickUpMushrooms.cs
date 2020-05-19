using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMushrooms : Quest
{
    private void Awake()
    {
        questName = "Zbierz grzyby";
        questDescripiton = "Zbierz 5 grzybow";
        questObjective = new QuestObjective(this, 5);
    }

    public void Finished()
    {
        Debug.Log($"Zadanie {questName} zaliczone.");
    }
}
