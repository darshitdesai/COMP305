using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2ClickHandler : MonoBehaviour {

    public GameObject gameObject2;

    public Sprite newImage1;

	// Use this for initialization
	void Start () {
        Rigidbody2D rBody = gameObject2.GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        SpriteRenderer sRend = gameObject2.GetComponent<SpriteRenderer>();
        sRend.sprite = newImage1;
    }
}
