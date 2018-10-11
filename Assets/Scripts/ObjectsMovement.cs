using UnityEngine;
using System.Collections;

public class ObjectsMovement : MonoBehaviour {

	public GameObject redBallObject;
	public GameObject blueBallObject;
	private GameObject[] redBallClones;
	private GameObject[] blueBallClones;
	private int ballsCount = 2;
	private int red = 0;
	private int blue = 0;
	private bool position = true;
	private bool nextLevel = false;
	private bool gyro;

	// Use this for initialization
	void Start () {
		ballsCount = GameManager.ballLsCount;

		redBallClones = new GameObject[ballsCount];
		blueBallClones = new GameObject[ballsCount];
		for (int i = 0; i < ballsCount; i++) {
			float x1;
            if (i % 2 == 0)
                x1 = Random.Range(1.0f, 6.0f);
            else
                x1 = Random.Range(-1.0f, -6.0f);
			redBallClones[i] = Instantiate(redBallObject, new Vector3(x1, Random.Range(2f,-2f), -2), transform.rotation) as GameObject;
			//redBallClones[i].rigidbody2D.AddForce(4,4,ForceMode.Impulse);
			redBallClones[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(40,40), ForceMode2D.Impulse);

			float x2;
			if(i % 2 == 0)
				x2 = Random.Range(1.0f,6.0f);
			else
				x2 = Random.Range(-1.0f,-6.0f);
		
			blueBallClones[i] = Instantiate(blueBallObject, new Vector3(x2, Random.Range(2f,-2f), -2), transform.rotation) as GameObject;
			//redBallClones[i].rigidbody2D.AddForce(4,4,ForceMode.Impulse);
			blueBallClones[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(40,40),ForceMode2D.Impulse);
		}

		
	}

	// Update is called once per frame
	void Update () {
		if (position) {
			for (int i = 0; i < ballsCount; i++) {
				if (redBallClones [i].transform.position.x > 0)	
					red++;
				if (blueBallClones [i].transform.position.x < 0)	
					blue++;
			}
			
			
		} else {
			for (int i = 0; i < ballsCount; i++) {
				if (redBallClones [i].transform.position.x < 0)	
					red++;
				if (blueBallClones [i].transform.position.x > 0)	
					blue++;
			}
			
		}
		if (red == ballsCount && blue == ballsCount) {
			Timer t = GetComponent<Timer> ();
			//SetScore(t.time);
			StartCoroutine (Delay ());
		}
		
		red = 0;
		blue = 0;
		for (int i = 0; i < ballsCount; i++) {
			if (redBallClones [i].transform.position.x < 0)	
				red++;
			if (blueBallClones [i].transform.position.x < 0)	
				blue++;
		}
		if (red > blue)
			position = false;
		else
			position = true;
		red = 0;
		blue = 0;
		for (int i = 0; i < ballsCount; i++) {
            if (Mathf.Abs(redBallClones[i].GetComponent<Rigidbody2D>().velocity.x) < 4 && Mathf.Abs(redBallClones[i].GetComponent<Rigidbody2D>().velocity.y) < 4)
            {
                redBallClones[i].GetComponent<Rigidbody2D>().velocity = new Vector3(redBallClones[i].GetComponent<Rigidbody2D>().velocity.x * 1.1f, redBallClones[i].GetComponent<Rigidbody2D>().velocity.y * 1.1f, 0);
            }


            if (Mathf.Abs(blueBallClones[i].GetComponent<Rigidbody2D>().velocity.x) < 4 && Mathf.Abs(blueBallClones[i].GetComponent<Rigidbody2D>().velocity.y) < 4)
            {
                blueBallClones[i].GetComponent<Rigidbody2D>().velocity = new Vector3(blueBallClones[i].GetComponent<Rigidbody2D>().velocity.x * 1.1f, blueBallClones[i].GetComponent<Rigidbody2D>().velocity.y * 1.1f, 0);
            }
            if (Mathf.Abs(redBallClones[i].GetComponent<Rigidbody2D>().velocity.x) > 8)
            {
                redBallClones[i].GetComponent<Rigidbody2D>().velocity = new Vector3(redBallClones[i].GetComponent<Rigidbody2D>().velocity.x / 1.1f, 0, 0);
            }
            if (Mathf.Abs(redBallClones[i].GetComponent<Rigidbody2D>().velocity.y) > 8)
            {
                redBallClones[i].GetComponent<Rigidbody2D>().velocity = new Vector3(0, redBallClones[i].GetComponent<Rigidbody2D>().velocity.y / 1.1f, 0);
            }

            if (Mathf.Abs(blueBallClones[i].GetComponent<Rigidbody2D>().velocity.x) > 8)
            {
                blueBallClones[i].GetComponent<Rigidbody2D>().velocity = new Vector3(blueBallClones[i].GetComponent<Rigidbody2D>().velocity.x / 1.1f, 0, 0);
            }
            if (Mathf.Abs(blueBallClones[i].GetComponent<Rigidbody2D>().velocity.y) > 8)
            {
                blueBallClones[i].GetComponent<Rigidbody2D>().velocity = new Vector3(0, blueBallClones[i].GetComponent<Rigidbody2D>().velocity.y / 1.1f, 0);
            }

		}
	}
	



	void SetScore
		(float f)
	{
		
	}
	IEnumerator Delay()
	{
		
		nextLevel = true;
		yield return new WaitForSeconds (2f);
		switch (GameManager.level) {
				
				case 1:
						Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;
				case 2:
			Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;

				case 3:
			Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;

				case 4:
			Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;

				case 5:
			Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;

				case 6:
			Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;

				case 7:
			Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;
				case 8:
			Application.LoadLevel ("Stage0" + (GameManager.level + 1));
						break;
				}
		GameManager.level++;
	}
	void OnGUI()
	{
		GUIStyle guiStyle = new GUIStyle ();
		guiStyle.fontSize = 60;
		guiStyle.normal.textColor = Color.white;
		GUILayout.BeginHorizontal ();
		if(nextLevel)
			GUI.TextField (new Rect (Screen.width / 2 - 80, Screen.height / 2 - 20, 80, 40), "Level" + (GameManager.level  +1), guiStyle);
        GUILayout.EndHorizontal();
	}
}
