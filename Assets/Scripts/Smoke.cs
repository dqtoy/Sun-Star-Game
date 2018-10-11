using UnityEngine;
using System.Collections;

public class Smoke : MonoBehaviour {
	private float x = 1.0f;
	// Use this for initialization
	void Start () {
		Color tempcolor = GetComponent<Renderer>().material.color;
		tempcolor.a = 0.19f;
		GetComponent<Renderer>().material.color = tempcolor;
			}
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * Time.deltaTime / 2);
		if (transform.position.y > 3f)
			Destroy (this.gameObject);


	}
}
