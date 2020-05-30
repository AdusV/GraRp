﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;
    public float speed;
   // public int damage;

  // private Animator anim;
   // public GameObject bloodEffect;

    /*private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }*/
    private void Update()
    {
        if(health<=0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
       // Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("damage");
    }
    
}
