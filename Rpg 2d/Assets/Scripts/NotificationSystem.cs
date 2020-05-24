﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NotificationSystem : MonoBehaviour
{
    [SerializeField] GameObject notificationPrefab;
    [SerializeField] Transform content;

    /// ******************************
    public static NotificationSystem Instance = null;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
    }
    /// ******************************
    public void AddNotification(string textOfNotification)
    {
        GameObject newNotification = Instantiate(notificationPrefab, content);
        newNotification.GetComponentInChildren<TextMeshProUGUI>().text = textOfNotification;
    }
    //private IEnumerator Start()
    //{
    //    AddNotification("Pierwsze powiadomienie");
    //    yield return new WaitForSeconds(2);
    //    AddNotification("Drugie powia");
    //    yield return new WaitForSeconds(2);
    //    AddNotification("Trzepow");
    //}

}
