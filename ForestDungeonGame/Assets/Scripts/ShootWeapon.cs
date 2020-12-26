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

    public Weapon weapon;

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

            StartCoroutine(CoolDownAwaiter(weapon.GetCoolDown()));
            //Projectille p = new Projectille();


        }
    }

    /**
     * This Function will block the canShoot as false until
     * the needed time has transpired
     **/
    IEnumerator CoolDownAwaiter(float dt)
    {
        canShoot = false;
        yield return new WaitForSeconds(dt);
        canShoot = true;
        
    }
}
