using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMushrooms : Quest
{
    private void Awake()
    {
        questName = "Zbierz grzyby";
        questDescripiton = "Zbierz 5 grzybow";
        questObjective = new CollectionObjective(this, 5, "mushroom");
    }
    private void Start()
    {
        NotificationSystem.Instance.AddNotification("Otrzymano nowy Quest: Zbierz grzyby ");
    }
    
   
    public override void Finished()
    {
        Achievementes.Instance.ActivateGrzybobranie();
        base.Finished();
    }

}
