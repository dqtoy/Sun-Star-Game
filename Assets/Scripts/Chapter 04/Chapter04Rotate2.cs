using UnityEngine;
using System.Collections;

public class Chapter04Rotate2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0, 0, -15f));
	}
}
