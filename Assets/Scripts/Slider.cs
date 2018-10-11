using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour {

	private Ray ray;
	private RaycastHit hit;
	private Vector3 prePosition;
	private bool gyro;
	// Use this for initialization
	void Start () {

		prePosition = Vector3.zero;
		transform.position = new Vector3 (transform.position.x, 1.657515f, transform.position.z);
		gyro = false;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButton (0)) {
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				transform.position = new Vector3(transform.position.x, hit.point.y + 1, transform.position.z);
			}
		}*/
	}
	void FixedUpdate () {
		if (!gyro) {
						if (Input.GetMouseButtonDown (0))
								prePosition = Vector3.zero;
						if (Input.GetMouseButton (0)) {
								if (prePosition == Vector3.zero) {
										prePosition = Input.mousePosition;
										return;
								}
								if (prePosition == Input.mousePosition)
										return;
								if (Input.mousePosition.y > prePosition.y) {
										if (transform.position.y > 5.786173f)
												return;
										Debug.Log ("up   " + prePosition.y + "    " + Input.mousePosition.y);
										float dis = Input.mousePosition.y - prePosition.y;
										transform.position = new Vector3 (transform.position.x, transform.position.y + dis / 35, transform.position.z);
								} else if (Input.mousePosition.y < prePosition.y) {
										if (transform.position.y < -6.841135f)
												return;
										Debug.Log ("down   " + prePosition.y + "    " + Input.mousePosition.y);
										float dis = Input.mousePosition.y - prePosition.y;
										transform.position = new Vector3 (transform.position.x, transform.position.y + dis / 35, transform.position.z); 
								}
								prePosition = Input.mousePosition;
						}
				} else if (gyro) {
				

			Input.gyro.enabled = true;
			transform.position = new Vector3(transform.position.x, transform.position.y + Input.gyro.attitude.y, transform.position.z);


		}
	}
}
