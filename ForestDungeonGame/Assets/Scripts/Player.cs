﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public int maxMana, mana;

    //public static Player Instance { get; private set; }
    public Player() : base()
    {
        maxMana = 5;
        mana = 5;
    }

    public Player(int mH, List<Weapon> wep, float s, int maxMan) : base(mH, wep, s)
    {
        maxMana = maxMan;
        mana = maxMana;
    }
    

    public int GetMana()
    {
        return mana;
    }
    public void SetMana(int m)
    {
        mana = m;
    }
    public void SetMaxMana(int m)
    {
        maxMana = m;
    }
    public void SubtractFromHealth(int dmg)
    {
        health = health - dmg;

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
