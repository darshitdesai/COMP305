using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3ClickHandler : MonoBehaviour {

    public GameObject gameObject3;

    public Sprite newImage2;
	// Use this for initialization
	void Start () {
        Rigidbody2D rbody = gameObject3.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        SpriteRenderer sRend = gameObject3.GetComponent<SpriteRenderer>();
        sRend.sprite = newImage2;
    }
}
