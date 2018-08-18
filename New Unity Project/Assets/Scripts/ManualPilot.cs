using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualPilot : MonoBehaviour
{
    public float moveVelocity = 0.1f;
    public float maxRangeX = 2.5f;
    public float maxRangeY = 4.5f;
    public float fireInterval;
    public GameObject bullet;

    private float _nextFire;
    private Vector2 currentPosition;
    private Vector2 nextposition;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        currentPosition = new Vector2(transform.position.x, transform.position.y);
        nextposition = getNextPosition();
        transform.position = Vector2.MoveTowards(currentPosition, nextposition, moveVelocity);
        getFireInput();
    }

    void getFireInput()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > _nextFire)
        {
            _nextFire = Time.time + fireInterval;
            Instantiate(bullet, new Vector2(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
    }

    Vector2 getNextPosition()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.y);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos = new Vector2(transform.position.x, maxRangeY);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            pos = new Vector2(transform.position.x, -maxRangeY);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos = new Vector2(-maxRangeX, transform.position.y);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos = new Vector2(maxRangeX, transform.position.y);
        }
        return pos;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyBullet")
        {
            gameObject.SetActive(false);
            GameManager.ShowRestartButton();
        }
    }
}
