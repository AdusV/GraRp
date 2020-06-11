using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PatrolEnemy : MonoBehaviour
{
    public Transform navStartPoint;
    public Transform navEndPoint;

    private Vector2 startPoint;
    private Vector2 endPoint;
    public float speed;

    private Vector2 currentEnemyPosition;

    private void Start()
    {
        startPoint = navStartPoint.position;
        endPoint = navEndPoint.position;
        Destroy(navStartPoint.gameObject);
        Destroy(navEndPoint.gameObject);
    }
    private void Update()
    {
        currentEnemyPosition = Vector2.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentEnemyPosition;
    }
}
