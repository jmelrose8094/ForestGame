using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 0;
    public float speed = 5f, deathTimer = 3f;
    public bool fromPlayer;
    //public GameObject Projectile;


    private Projectile()
    {
    }

    public Projectile(int d, float s, float dt, bool fp)
    {
        damage = d;
        speed = s;
        deathTimer = dt;
        fromPlayer = fp;
    }

    void Start()
    {
        StartCoroutine(SelfDestruct(deathTimer));
    }

    void Update()
    {
        transform.Translate(0, -Time.deltaTime *10f, 0);
    }


    public void Initilize(int d, float s, float dt, bool fp)
    {
        damage = d;
        speed = s;
        deathTimer = dt;
        fromPlayer = fp;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");

        if  (other.gameObject.tag == "Enemy" && fromPlayer == true)
        {
            other.gameObject.GetComponent<Enemy>().SubtractFromHealth(damage);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.tag == "Breakable")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.tag == "Player" && fromPlayer == false)
        {
            other.gameObject.GetComponent<Player>().SubtractFromHealth(damage);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.name != "Player" && fromPlayer == true)
        {
            Destroy(this.gameObject);
        }
        
    }

    public int GetDamage()
    {
        return damage;
    }

    IEnumerator SelfDestruct(float dt)
    {
        yield return new WaitForSeconds(dt);
        Destroy(gameObject);
    }


    public void FireProjectille()
    {
        //TODO finish this
    }
}
