using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peasant : MonoBehaviour
{

    [SerializeField] GameObject quests;
    [SerializeField] GameObject Wheat;

    private void Start()
    {
        quests = GameObject.Find("Quest");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Wheat.AddComponent<AddingCactusQuest>();
        quests.AddComponent<WheatQuest>();
    }


}
