using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodSpawner : MonoBehaviour
{
    public GameObject asteriodPrefab;
    public float spawnTime = 1.0f;
    public int spawnAmount = 5;
    public float trajectoryVariance = 15.0f;
    private Vector2 screenBounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteriodWave());
    }

    private void spawn()
    {
        for (int i = 0; i < this.spawnAmount; i++) {
            GameObject asteriod = Instantiate(this.asteriodPrefab) as GameObject;
            asteriod.transform.position = new Vector2(
                Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
        }
    }

    IEnumerator asteriodWave() {
        while (true) {
            yield return new WaitForSeconds(spawnTime);
            spawn();
        }
    }
}
