using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject score;
    public TextMeshProUGUI finalScore;
    public TextMeshProUGUI currScore;
    public GameObject spawner;

    void Awake() 
    {
        isGameOver = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) {
            gameOverScreen.SetActive(true);
            spawner.SetActive(false);
            finalScore.SetText(currScore.text);
            score.SetActive(false);
        }
    }
    public void replayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
