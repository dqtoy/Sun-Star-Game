using UnityEngine;
using System.Collections;

public class Bubbles : MonoBehaviour {

	public GameObject bubble;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range (-4.5f, -6.7f);
		int xx = Random.Range (1, 50);
		if (xx > 48) {
			GameObject o = Instantiate(bubble, new Vector3(x, bubble.transform.position.y, -1 ), bubble.transform.rotation) as GameObject;		
			float s = Random.Range(.1f, .4f);
			o.transform.localScale = new Vector3(s,s,.4f);
		}

		float x1 = Random.Range (4.5f, 6.7f);
		int xx1 = Random.Range (1, 50);
		if (xx1 > 48) {
			GameObject o = Instantiate(bubble, new Vector3(x1, bubble.transform.position.y, -1), bubble.transform.rotation) as GameObject;		
			float s = Random.Range(.1f, .4f);
			o.transform.localScale = new Vector3(s,s,.4f);
		}
	}
}
