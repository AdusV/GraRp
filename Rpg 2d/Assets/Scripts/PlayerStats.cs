using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int breathingTime;
    [SerializeField] private int maxBreathingTime;

    [SerializeField] private int regenerationRate;

    [SerializeField] private int levelXP = 1;
    [SerializeField] private int points = 0;

    [SerializeField] int[] pointsForXPLevels;

    /// ******************************
    public static PlayerStats Instance = null;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }
    /// ******************************
    public void Regeneration()
    {
        breathingTime += regenerationRate;
        Debug.Log("Breathing time:" + breathingTime);
    }
}
