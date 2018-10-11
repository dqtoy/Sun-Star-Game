using UnityEngine;
using System.Collections;

public class Smokes : MonoBehaviour {
	public GameObject smoke;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range (-3.625923f, -3.825923f);
		int xx = Random.Range (1, 50);
		if (xx > 30) {
			Instantiate(smoke, new Vector3(x, 0.0695129f, -1 ), smoke.transform.rotation);		

		}
	}
}
