﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tent : MonoBehaviour
{

    [SerializeField] GameObject quests;
    [SerializeField] GameObject pinkDiamond;

    private void Start()
    {
        
        quests = GameObject.Find("Quests");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (pinkDiamond == true)
        {
            // pinkDiamond.AddComponent<AddingWheatQuest>();
            quests.AddComponent<PinkDiamondQuest>();
        }
    }
}
