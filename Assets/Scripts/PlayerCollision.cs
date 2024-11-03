using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject score;
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.transform.tag == "Enemy") {
            PlayerManager.isGameOver = true;
            score.GetComponent<ScoreManager>().setZero();
            gameObject.SetActive(false);
        }
    }
}
