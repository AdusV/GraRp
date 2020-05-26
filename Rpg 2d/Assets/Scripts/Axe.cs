using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField] int points;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats.Instance.AddPoints(points);
        EventController.ItemPickedUp("axe");
        Destroy(this.gameObject);
    }
}
