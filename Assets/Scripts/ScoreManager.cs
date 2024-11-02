using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreValueText;
    public float scoreValue = 0f;
    public float pointIncreasePerSecond = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        scoreValueText.text = ((int)scoreValue).ToString();
        scoreValue += pointIncreasePerSecond * Time.deltaTime;
    }
}
