using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

    public GameObject gameObject1,gameObject2;

    public Sprite newImage;
	// Use this for initialization
	void Start () {
        Rigidbody2D rBody = gameObject1.GetComponent<Rigidbody2D>();
        Rigidbody2D rBody1 = gameObject2.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        SpriteRenderer sRend = gameObject1.GetComponent<SpriteRenderer>();
        SpriteRenderer sRend1 = gameObject2.GetComponent<SpriteRenderer>();
        sRend.sprite = newImage;
        sRend1.sprite = newImage;
    }
}
