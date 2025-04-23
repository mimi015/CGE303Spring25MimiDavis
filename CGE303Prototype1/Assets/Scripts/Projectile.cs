using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Projectile class that controls the movment of the projectile
// Attach this script to the projectile prefab 
public class Projectile : MonoBehaviour
{
    // Rigidbody2d component of the projectile
    private Rigidbody2D rb;
    public float speed = 20f;
    public int damage = 20;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy !=null)
        {
            enemy.TakeDamage(damage);
        }

        if(hitInfo.gameObject.tag != "Player")
        {
            Instantiate(impactEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
