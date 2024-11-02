using UnityEngine;

public class Asteriod : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody;
    public Sprite[] sprites;
    public float minSize = 0.5f;
    public float maxSize = 3.0f;
    public float maxLifetime = 30.0f;
    public float speed = 10.0f;

    private void Start()
    {
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        this.transform.localScale = Vector3.one * Random.Range(minSize, maxSize);
    }

    // Update is called once per frame
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void SetTrajectory(Vector2 direction) {
        rigidbody.AddForce(direction * this.speed);
        Destroy(this.gameObject, this.maxLifetime);
    }
}
