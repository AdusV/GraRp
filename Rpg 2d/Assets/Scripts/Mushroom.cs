using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField] int points;
    public AudioClip clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats.Instance.AddPoints(points);
        EventController.ItemPickedUp("mushroom");
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy(this.gameObject);
    }
}
