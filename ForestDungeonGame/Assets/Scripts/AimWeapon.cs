using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class AimWeapon : MonoBehaviour
{
    public event EventHandler<OnShootArgs> OnShoot;
    public class OnShootEventArgs : EventArgs
    {
        public Vector3 projectileSpawnPoint;
    }
    public Transform wepTransform;

    private void Awake()
    {
        wepTransform = transform.Find("Weapon");
    }

    private void Update()
    {
        HandleAiming();

    }

    private void HandleAiming()
    {
        Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();

        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        wepTransform.eulerAngles = new Vector3(0, 0, angle);
    }


}
