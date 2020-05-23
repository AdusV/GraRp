using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusQuest : Quest
{
    private void Awake()
    {
        questName = "Kaktus";
        questDescripiton = "Znajdz kaktus, aby przyspieszczyc regeneracje jescze bardziej";
        questObjective = new CollectionObjective(this, 1, "cactus");
    }

    public override void Finished()
    {
        PlayerStats.Instance.UpdateRegenartionRate(3);
        base.Finished();
    }
}
