using UnityEngine;
using System.Collections;

public class ScrollLevels : MonoBehaviour {
	private Vector3 prePosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {

			transform.Translate(new Vector3());		
		}
	}
	void FixedUpdate () {

			if (Input.GetMouseButtonDown (0))
				prePosition = Vector3.zero;
			if (Input.GetMouseButton (0)) {
				if (prePosition == Vector3.zero) {
					prePosition = Input.mousePosition;
					return;
				}
				if (prePosition == Input.mousePosition)
					return;
				if (Input.mousePosition.x > prePosition.x) {
					
					Debug.Log ("right   " + prePosition.x + "    " + Input.mousePosition.x);
					float dis = Input.mousePosition.y - prePosition.y;
					transform.position = new Vector3 (transform.position.x, transform.position.y + dis / 35, transform.position.z);
				} else if (Input.mousePosition.x < prePosition.x) {
					
					Debug.Log ("left   " + prePosition.x + "    " + Input.mousePosition.x);
					float dis = Input.mousePosition.x - prePosition.x;
					transform.position = new Vector3 (transform.position.x + dis /35, transform.position.y, transform.position.z); 
				}
				prePosition = Input.mousePosition;
			}

	}
}
