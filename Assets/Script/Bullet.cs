using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 05f;
    public Rigidbody2D rb;
    public int score;

    // Use this for initialization
    void Start()
    {
        score = 0;
        if (this.tag == "bullet")
        {
            rb.velocity = transform.right * speed;
        }
        else if (this.tag == "bullet1")
        {
            rb.velocity = transform.right * -speed;
        }
        else if (this.tag == "bullet2")
        {

            rb.velocity = transform.up * speed;
        }
        else if (this.tag == "bullet3")
        {
            rb.velocity = transform.up * -speed;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);

        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy != null)
        {
            //A variavel damage é o quanto de dano quero dar no inimigo, nesse caso ele morre na hora
            int damage = 100;
            if (enemy.CompareTag("enemy1"))
            {
                enemy.TakeDamage(damage);
                Destroy(gameObject);
                score++;
                Debug.Log("Score: " + score);
            }
            }
    }
}