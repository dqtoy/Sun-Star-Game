using UnityEngine;
using System.Collections;

public class YellowEyes : MonoBehaviour {


	// Use this for initialization
	void Start () {
		InvokeRepeating ("b",Random.Range(3.0f, 10.0f), Random.Range(3.0f, 5.0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void b(){
		this.GetComponent<Renderer>().enabled = false;
		StartCoroutine (waitfor(.2f));

	}
	IEnumerator waitfor(float t)
	{
		yield return new WaitForSeconds (t);
		GetComponent<Renderer>().enabled = true;
	}
}
