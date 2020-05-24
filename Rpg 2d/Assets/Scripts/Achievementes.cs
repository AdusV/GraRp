using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievementes : MonoBehaviour
{
    [SerializeField] AchivementBadge odkrycieBieguna;
    [SerializeField] AchivementBadge grzybobranie;
    [SerializeField] AchivementBadge lodySzpiankowe;
    [SerializeField] AchivementBadge rozmowaZPrzybyszem;

    /// ******************************
    public static Achievementes Instance = null;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }
    /// ******************************

    public void ActivateOdkrycieBieguna()
    {
        odkrycieBieguna.ActivateBadge();
    }
    public void ActivateGrzybobranie()
    {
        grzybobranie.ActivateBadge();
        NotificationSystem.Instance.AddNotification("Przyznano odznake \"Grzybobranie\". ");
    }
    public void ActivateLodySzpinakowe()
    {
        lodySzpiankowe.ActivateBadge();
    }
    public void ActivateRozmowaZPrzybyszem()
    {
        rozmowaZPrzybyszem.ActivateBadge();
    }

}
