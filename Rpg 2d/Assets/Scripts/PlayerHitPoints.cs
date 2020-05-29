using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitPoints : MonoBehaviour
{
   public int maxHitPoints;
    [SerializeField] public float hitPoints;
    bool isGameOver = false;

   
    void HitPoints()
    {
        PlayerStats.Instance.UpdateHitPoints(maxHitPoints);
    }
    private void Start()
    {
        hitPoints = maxHitPoints;
    }
    private void Update()
    {
        if (hitPoints <= 0 && !isGameOver)
        {   
            isGameOver = true;
            //GameManager.Instance.PlayerDeath();
        }
    }
    void EnemyHit(float damage)
    {
        hitPoints -= damage;
    }
}
