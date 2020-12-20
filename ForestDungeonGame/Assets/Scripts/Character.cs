using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth, health;
    public List<Weapon> weapons;
    public float speed;


    public Character()
    {
        maxHealth = 1;
        speed = 1;
    }

    public Character(int h, List<Weapon> w, float s)
    {
        maxHealth = h;
        health = maxHealth;
        weapons = w;
        speed = s;
    }
    
    public int GetHealth()
    {
        return health;
    }

    public List<Weapon> GetWeapon()
    {
        return weapons;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetHealth(int h)
    {
        health = h;
    }
    public void SetWeapon(List<Weapon> w )
    {
        weapons = w;
    }
    public void SetSpeed(float s)
    {
        speed = s;
    }
    public void AddWeapon(Weapon w)
    {
        weapons.Add(w);
    }
    public void RemoveWeapon(Weapon w)
    {
        weapons.Remove(w);
    }
}
