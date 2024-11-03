using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float minY = -10.2f;
    public float speed = 10.0f;
    public float currentPositionY = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        currentPositionY -= speed;
        this.gameObject.transform.position = new Vector3(0, currentPositionY, 0);
        if (currentPositionY < minY) {
            this.gameObject.transform.position = new Vector3(0, 20.4f, 0);
            currentPositionY = 0;
        }
    }
}
