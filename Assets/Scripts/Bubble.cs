﻿using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * Time.deltaTime);
		if (transform.position.y > 6f)
						Destroy (this.gameObject);
	}
}
