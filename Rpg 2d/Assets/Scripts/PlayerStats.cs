using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int breathingTime; 
    public int BreathingTime
    {
        get { return breathingTime; }       
    }

    [SerializeField] private int maxBreathingTime;
    [SerializeField] private int breathingIncreaseByXPLevel;

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
        breathingTime = Mathf.Clamp(breathingTime + regenerationRate,0,maxBreathingTime);
        Debug.Log("Breathing time:" + breathingTime);
    }

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        Debug.Log($"points: {points}");

        if (points > pointsForXPLevels[levelXP] && levelXP < pointsForXPLevels.Length - 1) 
        {
            levelXP++;
            points = 0;
            maxBreathingTime += breathingIncreaseByXPLevel;
        }
    }

    public void UpdateBreathingTime(int valueToSub)
    {
        breathingTime -= valueToSub;
    }
}
