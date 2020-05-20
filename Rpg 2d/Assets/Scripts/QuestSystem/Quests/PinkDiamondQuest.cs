using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkDiamondQuest : Quest
{
    private void Awake()
    {
        questName = "Rozowy diament";
        questDescripiton = "Znajdz rozowy diament, aby przyspieszyc regeneracje";
        questObjective = new CollectionObjective(this, 1, "pinkDiamond");
    }

    public override void Finished()
    {
        PlayerStats.Instance.UpdateRegenartionRate(3);
        base.Finished();
    }
}
