using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : Projectile
{
    public PlayerProjectile() : base()
    { }

    new public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");

        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Enemy>().SubtractFromHealth(damage);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "Breakable")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
