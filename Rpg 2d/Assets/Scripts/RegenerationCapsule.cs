using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenerationCapsule : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        InvokeRepeating("RegenerationStep", 0, 1);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CancelInvoke("RegenerationStep");
    }
    private void RegenerationStep()
    {
        PlayerStats.Instance.Regeneration();
    }
}
