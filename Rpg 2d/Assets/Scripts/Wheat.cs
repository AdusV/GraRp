﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat : MonoBehaviour
{
    [SerializeField] int points;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats.Instance.AddPoints(points);
        EventController.ItemPickedUp("wheat");
        Destroy(this.gameObject);
    }

}
