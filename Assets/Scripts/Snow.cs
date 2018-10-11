using UnityEngine;
using System.Collections;

public class Snow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(-.1f * 2,-.1f * 2,0));
        if (transform.position.y < -6f)
			Destroy (this.gameObject);
	}
}
