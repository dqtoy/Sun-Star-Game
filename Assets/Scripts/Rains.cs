using UnityEngine;
using System.Collections;

public class Rains : MonoBehaviour {

	public GameObject rain;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range (-7.5f, 14.5f);
		int xx = Random.Range (1, 50);
		if (xx > 1) {
			GameObject o = Instantiate(rain, new Vector3(x, 5f, -1 ), rain.transform.rotation) as GameObject;		

		}
	}
}
