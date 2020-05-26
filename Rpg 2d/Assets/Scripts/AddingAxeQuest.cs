﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingAxeQuest : MonoBehaviour
{
  [SerializeField] GameObject quests;
    private void Start()
    {
        quests = GameObject.Find("Quests");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        quests.AddComponent<AxeQuest>();
    }
}