using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;
    public float coolDown;

    public Weapon()
    {
        damage = 1;
        coolDown = 1;
    }
    public Weapon(int d, float c)
    {
        damage = d;
        coolDown = c;
    }

    public float GetCoolDown()
    {
        return this.coolDown;
    }

    public int GetDamage()
    {
        return this.damage;
    }
}
