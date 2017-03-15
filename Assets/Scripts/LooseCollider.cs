﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {
    private LevelManager levelManager;

    
    void OnTriggerEnter2D(Collider2D trigger)
    {
       
        levelManager =  GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel ("Loose Scene");
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        print("The Collision");
    }
}
