using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatQuest : Quest
{
    private void Awake()
    {
        questName = "Pszenica";
        questDescripiton = "Prosze dobrodzieju znajdz sam moja pszenica zly Warlock Adama's ja ukryl i nie wiem jak zyc bez niej sam";
        questObjective = new CollectionObjective(this, 1, "wheat");
    }
    public override void Finished()
    {
        PlayerStats.Instance.UpdateBreathingTime(5);
        base.Finished();
    }


}
