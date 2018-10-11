using UnityEngine;
using System.Collections;

public class FinishPage : MonoBehaviour {

    public Sprite[] sprites;
    public SpriteRenderer r;

    public TextMesh level;
    public TextMesh time;
    private bool ok = true;
	// Use this for initialization
	void Start () {
        //level.text = GameManager.level.ToString();
       
            //time.font = f; 
            time.text = ((int)(GameManager.time - 6.5f)).ToString();
            ok = false;
        
        switch (GameManager.currentChapter)
        {
            case 1:
                level.text = GameManager.level1.ToString();
                break;
            case 2:
                level.text = GameManager.level2.ToString();
                break;
            case 3:
                level.text = GameManager.level3.ToString();
                break;
            case 4:
                level.text = GameManager.level4.ToString();
                break;
            case 5:
                level.text = GameManager.level5.ToString();
                break;
            case 6:
                level.text = GameManager.level6.ToString();
                break;
            case 7:
                level.text = GameManager.level7.ToString();
                break;
        }
        Sprite sprite = null;
        int current = 1;
        for (int i = 1; i < 8; i++ )
        {
            if (GameManager.currentChapter == i)
                current = i;    
        }
        r.sprite = sprites[current];

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        
    }
}
