using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : Projectile
{
    public EnemyProjectile() : base()
    { }

    new public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");

        if (other.gameObject.tag == "Breakable")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.tag == "Player" )
        {
            other.gameObject.GetComponent<Player>().SubtractFromHealth(damage);
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
}
