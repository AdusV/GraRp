using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenerationCapsule : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<PlayerBreathing>().StopBreathing();
        InvokeRepeating("RegenerationStep", 0, 1);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<PlayerBreathing>().StartBreathing();
        CancelInvoke("RegenerationStep");
    }
    private void RegenerationStep()
    {
        PlayerStats.Instance.Regeneration();
    }
}
