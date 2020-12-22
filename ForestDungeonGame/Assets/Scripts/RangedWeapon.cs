using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : Weapon
{
    public float deathTimer = 3f, speed;

    public RangedWeapon() : base()
    {
        deathTimer = 3f;
        speed = 10f;
    }
    
    public RangedWeapon(int d, float c, float dt, float s) : base(d, c)
    {
        deathTimer = dt;
        speed = s;
    }

    public void LaunchProjectile()
    {

    }

}
