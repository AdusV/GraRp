using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBreathing : MonoBehaviour
{

    [SerializeField] int breathingPoints;
    private void Start()
    {
        InvokeRepeating("Breathe", 0, 1);
    }
    void Breathe()
    {
        PlayerStats.Instance.UpdateBreathingTime(breathingPoints);
        Debug.Log(PlayerStats.Instance.BreathingTime);
    }
}
