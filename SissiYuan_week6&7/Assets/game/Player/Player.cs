using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public SpriteRenderer sr;
    public Animator ani;
    public GameObject bulletGO;

    Vector2 shootDirection;

    void Start()
    {
        shootDirection = Vector2.right;
    }

    void Update()
    {
        ani.SetBool("toWalk", false);
        ani.SetBool("toWalkBack", false);
        ani.SetBool("toWalkFront", false);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
            ani.SetBool("toWalkBack", true);

            shootDirection = Vector2.up;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            ani.SetBool("toWalkFront", true);

            shootDirection = Vector2.down;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            ani.SetBool("toWalk", true);
            sr.flipX = true;

            shootDirection = Vector2.left;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            ani.SetBool("toWalk", true);
            sr.flipX = false;

            shootDirection = Vector2.right;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject newBulletGO = Instantiate(bulletGO, transform.position, Quaternion.identity);
            newBulletGO.GetComponent<Bullet>().SetShootDirection(shootDirection);
        }
    }
}
