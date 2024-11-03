using UnityEngine;

public class ConstantFall : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < - 5.5){
            GetComponent<Rigidbody2D>().position = new Vector2(-5, 6);
        }
    }
}
