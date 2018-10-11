using UnityEngine;
using System.Collections;

public class Mets : MonoBehaviour {
	public GameObject met;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int xx = Random.Range (1, 300);
		if (xx > 280) {
			Instantiate(met, new Vector3(10f, Random.Range(-3.0f , 10.0f), -0.8f ), met.transform.rotation);			
		}
	}
}