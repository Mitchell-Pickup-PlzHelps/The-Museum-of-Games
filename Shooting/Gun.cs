using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;
    public GameObject flash;
    public GameObject PFlash;

  
    void Update()
    {
        if (Input.GetButtonDown ("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            Destroy(instantiatedProjectile.gameObject, 2);
            audioSource.Play();
            Instantiate(PFlash, flash.transform.position, flash.transform.rotation);
           // Destroy(PFlash.gameObject, 2);
        }
        
    }
   
    IEnumerator DestroyPellet()
    {
        yield return new WaitForSeconds(2);
        float bulletLife = 1.0f;
        Destroy(GameObject.Find("Pellet(Clone)"), bulletLife); 
    }
}