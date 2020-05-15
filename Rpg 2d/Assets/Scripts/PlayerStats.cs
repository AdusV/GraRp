using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int breathingTime;
    [SerializeField] private int maxBreathingTime;

    [SerializeField] private int regenerationRate;

    public void Regeneration()
    {
        breathingTime += regenerationRate;
    }
}
