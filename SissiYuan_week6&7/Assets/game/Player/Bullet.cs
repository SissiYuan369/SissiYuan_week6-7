using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float life;
    public Rigidbody2D rb2D;

    Vector2 shootDirection;

    private void Start()
    {
        Invoke(nameof(Dead), life);
    }
    private void FixedUpdate()
    {
        rb2D.linearVelocity = speed * Time.deltaTime * shootDirection;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            Dead();

            enemy.Dead();
        }
    }

    void Dead()
    {
        Destroy(gameObject);
    }

    public void SetShootDirection(Vector2 dir)
    {
        shootDirection = dir;
    }
}
