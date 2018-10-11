using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.level1 = PlayerPrefs.GetInt("chapter01_level", 1);
        GameManager.level2 = PlayerPrefs.GetInt("chapter02_level", 1);
        GameManager.level3 = PlayerPrefs.GetInt("chapter03_level", 1);
        GameManager.level4 = PlayerPrefs.GetInt("chapter04_level", 1);
        GameManager.level5 = PlayerPrefs.GetInt("chapter05_level", 1);
        GameManager.level6 = PlayerPrefs.GetInt("chapter06_level", 1);
        GameManager.level7 = PlayerPrefs.GetInt("chapter07_level", 1);

        GameManager.Chapter = PlayerPrefs.GetInt("Chapter", 7);

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
		if ( Input.GetMouseButtonUp( 0 ) )
		{
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint( Input.mousePosition );
			RaycastHit2D hit = Physics2D.Raycast( worldPoint, Vector2.zero );
			if ( hit.collider != null )
			{

				if(hit.collider.name == "Play")
                    Application.LoadLevel("ChaptersPage");
				else if(hit.collider.name == "Rate")
                    Application.OpenURL("itms-apps://itunes.apple.com/app/idAPP_ID");
                else if (hit.collider.name == "About")
                    Application.OpenURL("http://www.dibagames.com/");
			    else if(hit.collider.name == "Exit")
                    Application.Quit();
            }
		}
	}
}
