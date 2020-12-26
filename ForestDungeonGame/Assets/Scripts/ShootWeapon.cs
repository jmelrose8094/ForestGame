using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class is responsible for creating a new projectille
 * as well as handling the cooldown for the combat
 **/
public class ShootWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform wepTransform;

    private bool canShoot = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleShooting();
    }

    private void HandleShooting()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            Projectille p = new Projectille();


        }
    }

    IEnumerator SelfDestruct(float dt)
    {
        yield return new WaitForSeconds(dt);
        Destroy(gameObject);
    }

    /**
     *  void Start()
    {
        StartCoroutine(SelfDestruct(deathTimer));
    }

    public int GetDamage()
    {
        return damage;
    }

    IEnumerator SelfDestruct(float dt)
    {
        yield return new WaitForSeconds(dt);
        Destroy(gameObject);
    }*/
}
