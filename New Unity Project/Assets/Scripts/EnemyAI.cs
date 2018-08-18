using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float enemySpeed = 0.1f;
    public float enemyBorderY = -6;
    public float fireInterval;
    public GameObject Bullet;

    private Vector2 currentPosition;
    private Vector2 mextPosition;
    private float _nextFire;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > enemyBorderY)
        {
            Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 nextPosition = new Vector2(transform.position.x, enemyBorderY);
            transform.position = Vector2.MoveTowards(currentPosition, nextPosition, enemySpeed);
        }
        else
        {
            Object.Destroy(this.gameObject);
        }

        if (Time.time > _nextFire)
        {
            _nextFire = Time.time + fireInterval;
            Instantiate(Bullet, new Vector2(transform.position.x, transform.position.y - 1), Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerBullet")
        {
            GameManager.AddScore(5);
            Object.Destroy(this.gameObject);
        }
    }
       
}
