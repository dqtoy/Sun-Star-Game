using UnityEngine;
using System.Collections;

public class StarBlink : MonoBehaviour {

	private bool visible;
	// Use this for initialization
	void Start () {
		visible = true;

		InvokeRepeating ("star", Random.Range(1,5), Random.Range(1,5));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void star()
	{
		if (visible) {
			GetComponent<Renderer>().enabled = true;
			visible = !visible;
				} else {
			GetComponent<Renderer>().enabled = false;
			visible = !visible;
		}
	}
}
