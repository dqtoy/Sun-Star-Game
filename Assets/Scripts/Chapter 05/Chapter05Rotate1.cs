using UnityEngine;
using System.Collections;

public class Chapter05Rotate1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0, 0, Random.Range(5f, 10f)));
	}
}
