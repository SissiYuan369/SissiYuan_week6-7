using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public Animator ani;

    HurtSound hurtSound;

    void Start()
    {
        hurtSound = FindObjectOfType<HurtSound>();
    }

    void Update()
    {
        transform.position += new Vector3(xSpeed, ySpeed, 0) * Time.deltaTime;

        if (ySpeed > 0) ani.SetBool("toBack", true);
        else ani.SetBool("toBack", false);

        if (xSpeed > 0) { transform.localScale = new Vector3(-1, 1, 1); }
        else if(xSpeed < 0) { transform.localScale = new Vector3(1, 1, 1); }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            hurtSound.DisplayARandomHurtText();
        }
    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
