using UnityEngine;

public class AsteroidSpawnScript : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnRate = 2;
    private float timer = 0;
    public float movedOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnAsteroid();
            timer = 0;
        }
    }
    void spawnAsteroid()
    {

        float leftPoint = transform.position.x - movedOffset;
        float rightPoint = transform.position.x + movedOffset; 

        Instantiate(asteroid, new Vector3(Random.Range(leftPoint, rightPoint), 10, 0), transform.rotation);
    }
}
