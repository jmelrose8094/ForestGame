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
    public Transform spawnPoint;
    public Weapon weapon;
    public GameObject Projectile;
    private bool canShoot = true;

    void Start()
    {
        
    }

    private void Awake()
    {
        spawnPoint = GameObject.Find("LaunchPoint").transform;
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
            GameObject temp = Instantiate(Projectile) as GameObject;
            temp.transform.position = spawnPoint.position;
            temp.transform.rotation = spawnPoint.rotation;
            
            //GameObject test = GameObject.FindGameObjectsWithTag("Projectile");
            //test.SetActive(true);
            Projectile.GetComponent<Projectile>().Initilize(weapon.GetDamage(), 1f, 1f, true);
        }
    }

    /**
     * This Function will block the canShoot as false until
     * the needed time has transpired
     **/
    IEnumerator CoolDownAwaiter(float t)
    {
        canShoot = false;
        yield return new WaitForSeconds(t);
        canShoot = true;
        
    }
}
