using UnityEngine;
using System.Collections;

public class GrassMove : MonoBehaviour {
	public GameObject game;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			Instantiate(game, new Vector3(Random.Range(-7f, 7f), Random.Range(4f,-3f), -2), transform.rotation);			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
