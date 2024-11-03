using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangePlane : MonoBehaviour
{
    public Sprite kite;
    public Sprite glider;
    public Sprite plane;
    public Sprite rocket;

    public GameObject wood;
    public GameObject sky;
    public GameObject space;
    public GameObject engine;
    public GameObject O2;
    
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.gameObject.GetComponent<SpriteRenderer>().sprite == kite){   
            this.gameObject.GetComponent<SpriteRenderer>().sprite = glider;
            wood.SetActive(false);
        } else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == glider){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = plane;
            engine.SetActive(false);
        } else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == plane){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = rocket;
            O2.SetActive(false);
            sky.SetActive(false);
            space.SetActive(true);
        }
    }
}
