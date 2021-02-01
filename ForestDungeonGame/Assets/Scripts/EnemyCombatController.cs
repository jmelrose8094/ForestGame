using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatController : MonoBehaviour
{
    public Transform wepTransform;
    public RectTransform playerTransform;
    public Transform spawnPoint;
    public Weapon weapon;
    public GameObject Projectile;
    private bool canShoot = true;

    public EnemyCombatController()
    { }
    
    private void Start()
    {
        wepTransform = transform.Find("EnemyWeapon");
        playerTransform = GameObject.Find("Player").GetComponent<RectTransform>();
        spawnPoint = GameObject.Find("EnemyLaunchPoint").transform;
    }
    

    // Update is called once per frame
    void Update()
    {
        HandleAiming();
        HandleShooting();
    }

    private void HandleAiming()
    {
        Vector3 playerPosition = playerTransform.position;

        Vector3 aimDirection = (playerPosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        wepTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    public void HandleShooting()
    {
        if (canShoot)
        {

            StartCoroutine(CoolDownAwaiter(weapon.GetCoolDown()));
            GameObject temp = Instantiate(EnemyProjectile) as GameObject;
            temp.transform.position = spawnPoint.position;
            temp.transform.rotation = spawnPoint.rotation;

            //GameObject test = GameObject.FindGameObjectsWithTag("Projectile");
            //test.SetActive(true);
            Projectile.GetComponent<EnemyProjectile>().Initilize(weapon.GetDamage(), 1f, 1f);
        }
    }
    IEnumerator CoolDownAwaiter(float t)
    {
        canShoot = false;
        yield return new WaitForSeconds(t);
        canShoot = true;

    }
}
