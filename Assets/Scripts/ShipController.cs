using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        PlayerMovement();
    }

    // Update is called once per frame
    void PlayerMovement()
    {
        float xpos = Input.GetAxis("Horizontal");
        float ypos = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xpos, ypos, 0) * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
