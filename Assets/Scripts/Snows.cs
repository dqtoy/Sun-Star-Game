using UnityEngine;
using System.Collections;

public class Snows : MonoBehaviour {
	public GameObject snow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Random.Range (-7.5f, 14.5f);
		int xx = Random.Range (1, 50);
		if (xx > 1) {
			GameObject o = Instantiate(snow, new Vector3(x, 5f, -1 ), snow.transform.rotation) as GameObject;			
		}
	}
}
