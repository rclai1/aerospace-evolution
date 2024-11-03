using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject score;
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.transform.tag == "Enemy") {
            Debug.Log("Game Over");
            score.GetComponent<ScoreManager>().setZero();
        }
    }
}
