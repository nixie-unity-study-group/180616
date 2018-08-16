using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    public float enemySpeed = 0.1f;
    public float enemyBorderY = -6;

    private Vector2 currentPosition;
    private Vector2 mextPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        GameManager.AddScore(5);
        Object.Destroy(this.gameObject);
    }
}
