using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public GameObject bulletPrefab;
    public AudioSource bulletSound;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject gameObject = Instantiate(bulletPrefab, transform.position, transform.rotation);
            gameObject.GetComponent<Rigidbody>().velocity = transform.forward * 10f;
            bulletSound.Play();
        }


    }
}
