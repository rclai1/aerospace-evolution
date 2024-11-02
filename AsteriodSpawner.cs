using UnityEngine;

public class AsteriodSpawner : MonoBehaviour
{
    public Asteriod asteriodPrefab;
    public float spawnRate = 1.0f;
    public int spawnAmount = 5;
    public float spawnY = 100.0f;
    public float asteriodSpeed = 50.0f;
    public float trajectoryVariance = 15.0f;
    public float spawnX = 50.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate);
    }

    private void Spawn()
    {
        for (int i = 0; i < this.spawnAmount; i++) {
            Vector3 spawnDirection = new Vector3(Random.Range(-spawnX, spawnX), spawnY, 0);
            Vector2 spawnPoint = this.transform.position + spawnDirection;

            float variance = Random.Range(-trajectoryVariance, trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

            Asteriod asteriod = Instantiate(this.asteriodPrefab, spawnPoint, rotation);
            
            asteriod.SetTrajectory(rotation * -spawnDirection);
        }
    }
}
