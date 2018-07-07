using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {
    public float scrollSpeed;

    private SpriteRenderer sprite;
    private Vector2 startPosition;
    private float spriteSizeY;

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
        startPosition = transform.position;
        spriteSizeY = sprite.bounds.size.y;
	}
	
	// Update is called once per frame
	void Update () {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, spriteSizeY);
        transform.position = startPosition + Vector2.down * newPosition;
	}
}
