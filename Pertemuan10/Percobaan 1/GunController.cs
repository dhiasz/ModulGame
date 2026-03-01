using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [Header("Cooldown")]
    [SerializeField] private float cooldown = 0.25f;
    private float cooldownTimer;

    [Header("References")]
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private Transform firepoint;
    [SerializeField] private Animator muzzleflashAnimator;


    private void Update()
    {
        cooldownTimer += Time.deltaTime;    
    }

    private void Shoot()
    {
        if (cooldownTimer < cooldown) return;
        GameObject bullet = Instantiate(bulletprefab, firepoint.position, firepoint.rotation, null);
        bullet.GetComponent<Projectile>().ShootBullet(firepoint);


        muzzleflashAnimator.SetTrigger("shoot");
        cooldownTimer = 0;

    }

    #region Input
    private void OnShoot()
    {
        Shoot();
    }
    #endregion
}
