﻿using GameData;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class AliveUnit : MonoBehaviour
{
    public float armor;
    public int health;

    ElementAttribute UnitElementType;

    protected void CheckForHealth()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ReceiveDamage(int damage)
    {
        health -= damage;
        CheckForHealth();
        Debug.Log(gameObject.name + " got damaged for " + damage + " damage");
    }
}
