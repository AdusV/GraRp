﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjective 
{
    public bool isFinished;
    public int amountToFinished;
    public int currentAmount;
    public Quest quest;
 

    public void IncreaseAmount(int amount)
    {
        currentAmount += amount;
        if(!isFinished && currentAmount >= amountToFinished)
        {
            isFinished = true;
            quest.Finished();
        }
    }
}
