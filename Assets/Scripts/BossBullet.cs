﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField]
    Component[] toDisable;
    [SerializeField]
    GameObject explosion;

    public float damage = 10f;
    public float destroyDelay;
    public Rigidbody2D rb;
    public float bulletSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        Destroy(gameObject, destroyDelay);
        rb.AddForce(bulletSpeed * transform.up,ForceMode2D.Impulse);
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(explosion, transform);

            collision.GetComponent<PlayerController>().ReceiveDamage(damage);
            foreach (Component obj in toDisable)
            {
                if (obj is Collider2D)
                    (obj as Collider2D).enabled = false;
                if (obj is SpriteRenderer)
                    (obj as SpriteRenderer).enabled = false;
                if (obj is Rigidbody2D)
                    (obj as Rigidbody2D).velocity = Vector2.zero;
            }
        }
        
    }
}
