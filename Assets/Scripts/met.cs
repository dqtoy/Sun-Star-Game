using UnityEngine;
using System.Collections;

public class met : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float x = Random.Range (0.01f,0.3359284f);
		transform.localScale = new Vector3(x,x,1);
	}
	
	void Update () {
		transform.Translate (new Vector3(-.2f * 2,-.053f * 2,0));
		if (transform.position.x < -7 )
			Destroy (this.gameObject);
	}
}
