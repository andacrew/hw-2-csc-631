using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
   public float range = 100f; 
   public Camera cam;
   public ParticleSystem muzzleFlash;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit; 
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range);

    }
}
