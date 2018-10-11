using UnityEngine;
using System.Collections;

public class BirdFly : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(-.06f,0,0));
		if (transform.position.x < -8.161846f)
						Destroy (this.gameObject);
	}
}
