using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Asteriod : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody;
    public float minSize = 0.5f;
    public float maxSize = 3.0f;
    public float speed = 10.0f;
    private Vector2 screenBounds;

    private void Start()
    {
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        this.transform.localScale = Vector3.one * Random.Range(minSize, maxSize);
    }

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void Update() {
       // if (this.transform.position.y < screenBounds.y) {
        //    Destroy(this.gameObject);
        //}
    }
    void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
