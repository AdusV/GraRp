using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingWheatQuest : MonoBehaviour
{
    [SerializeField] GameObject quests;
    private void Start()
    {
        quests = GameObject.Find("Quests");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        quests.AddComponent<WheatQuest>();
    }
}
