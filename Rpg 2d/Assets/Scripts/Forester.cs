using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forester : MonoBehaviour
{
    [SerializeField] GameObject quests;
    [SerializeField] GameObject axe;

    private void Start()
    {                   
            quests = GameObject.Find("Quests");       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //axe.GetComponent<AddingCactusQuest>();
        if(axe==true)
        {
        quests.AddComponent<AxeQuest>();
           

        }
        
    }
}
