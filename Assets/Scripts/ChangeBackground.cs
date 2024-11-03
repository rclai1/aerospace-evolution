using UnityEngine;

public class ChangeBackgorund : MonoBehaviour
{
    public GameObject sky;
    public GameObject space;
    public bool isSpace;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackGroundChange()
    {
        sky.SetActive(false);
        space.SetActive(true);
    }
}
