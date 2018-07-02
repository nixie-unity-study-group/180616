using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPilot: MonoBehaviour
{
    private bool isMoveRight = true;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 5.0f & isMoveRight)
        {
            Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 nextPosition = new Vector2(5, 0);
            transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);
        }
        else if (transform.position.x >= 5.0f & isMoveRight)
        {
            isMoveRight = false;
        }
        else if (transform.position.x <= -5.0f & !isMoveRight)
        {
            isMoveRight = true;
        }
        else if (transform.position.x > -5.0f & !isMoveRight)
        {
            Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 nextPosition = new Vector2(-5, 0);
            transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);
        }
    }
}
