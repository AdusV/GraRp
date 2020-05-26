using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeQuest : Quest
{
    private void Awake()
    {
        questName = "Axe";
        questDescripiton = "Znajdz topor";
        questObjective = new CollectionObjective(this, 1, "axe");
    }
    public override void Finished()
    {
        PlayerStats.Instance.UpdateBreathingTime(15);
        base.Finished();
    }
}
