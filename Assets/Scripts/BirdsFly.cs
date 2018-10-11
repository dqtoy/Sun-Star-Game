using UnityEngine;
using System.Collections;

public class BirdsFly : MonoBehaviour {
	public GameObject obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float y = Random.Range (1.20f, 4.40f);
		int xx = Random.Range (1, 1000);
		if (xx > 980) {
			Instantiate(obj, new Vector3(8.630491f, y, -.2f ), obj.transform.rotation);	
		}
	}
}
