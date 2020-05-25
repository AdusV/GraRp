using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    public int LevelXp
    {
        get { return levelXP; }
        set { levelXP = value; }   
    }
    [SerializeField] private int points = 0;

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    [SerializeField] int[] pointsForXPLevels;

    [Header("Interface")]
    [SerializeField] Image breathingBar;
    [SerializeField] TextMeshProUGUI pointsText;

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

    private void Start()
    {
        InvokeRepeating("UpdateBreathingBarUI", 0, 0.1f);
    }
    public void Regeneration()
    {
        breathingTime = Mathf.Clamp(breathingTime + regenerationRate,0,maxBreathingTime);
        //Debug.Log("Breathing time:" + breathingTime);
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
        UpdatePointsTextUI();
    }

    public void UpdateBreathingTime(int valueToSub)
    {
        breathingTime -= valueToSub;
        
    }

    public void UpdateRegenartionRate(int valueToAdd)
    {
        regenerationRate += valueToAdd;
        Debug.Log($"Nowa wartosc regeneracji to{regenerationRate}.");
    }

    void UpdateBreathingBarUI()
    {
        breathingBar.fillAmount = breathingTime / (float)maxBreathingTime;
        Debug.Log($"fillAmount: {breathingTime / (float)maxBreathingTime}");
    }
    void UpdatePointsTextUI()
    {
        pointsText.text = points.ToString();
    }
}
