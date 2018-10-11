using UnityEngine;
using System.Collections;

public class ExitPage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null)
            {

                
                if (hit.collider.name == "Continue")
                {
                    Destroy(this.gameObject);
                    GameManager.exit = false;
                    Time.timeScale = 1f;
                }
                else if (hit.collider.name == "Again")
                {
                    Time.timeScale = 1f;
                    Application.LoadLevel(Application.loadedLevel);
                    GameManager.exit = false;
                }
                else if (hit.collider.name == "Menu")
                {
                    Time.timeScale = 1f;
                    Application.LoadLevel("ChaptersPage");
                    GameManager.exit = false;
                    GameObject sound = GameObject.Find("Sound") as GameObject;
                    sound.GetComponent<AudioSource>().volume = 1;
                }
                else if (hit.collider.name == "Exit")
                {
                    Time.timeScale = 1f;
                    Application.Quit();
                }
                
            }
        }
	}
}
