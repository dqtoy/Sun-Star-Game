using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetMouseButtonUp( 0 ) )
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint( Input.mousePosition );
			RaycastHit2D hit = Physics2D.Raycast( worldPoint, Vector2.zero );
			if ( hit.collider != null )
			{
				if(hit.collider.name.StartsWith("Stage"))
					Application.LoadLevel(hit.collider.name);
			}
		}
	}
}
