using UnityEngine;
using System.Collections;

public class CamAspect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<Camera>().aspect = 16f / 10f;
        Camera.main.aspect = 16f / 10f;
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.aspect = 16f / 10f;
	}
}
