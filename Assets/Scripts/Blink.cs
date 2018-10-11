using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetInteger ("stateBlink", 2);
		//InvokeRepeating ("animate", 2, 5);
	}
	
	// Update is called once per frame
	void Update () {


	}
	void animate()
	{
			anim.SetInteger ("stateBlink", 2);
	}
}
