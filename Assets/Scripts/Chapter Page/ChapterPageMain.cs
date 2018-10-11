using UnityEngine;
using System.Collections;

public class ChapterPageMain : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            switch (GameManager.Chapter)
            {
                case 1:
                    break;
                case 2:
                    Destroy(GameObject.Find("lock_cloud_2").gameObject);
                    break;
                case 3:
                    Destroy(GameObject.Find("lock_cloud_2").gameObject);
                    Destroy(GameObject.Find("lock_cloud_3").gameObject);
                    break;
                case 4:
                    Destroy(GameObject.Find("lock_cloud_2").gameObject);
                    Destroy(GameObject.Find("lock_cloud_3").gameObject);
                    Destroy(GameObject.Find("lock_cloud_4").gameObject);
                    break;
                case 5:
                    Destroy(GameObject.Find("lock_cloud_2").gameObject);
                    Destroy(GameObject.Find("lock_cloud_3").gameObject);
                    Destroy(GameObject.Find("lock_cloud_4").gameObject);
                    Destroy(GameObject.Find("lock_cloud_5").gameObject);
                    break;
                case 6:
                    Destroy(GameObject.Find("lock_cloud_2").gameObject);
                    Destroy(GameObject.Find("lock_cloud_3").gameObject);
                    Destroy(GameObject.Find("lock_cloud_4").gameObject);
                    Destroy(GameObject.Find("lock_cloud_5").gameObject);
                    Destroy(GameObject.Find("lock_cloud_6").gameObject);
                    break;
                case 7:
                    Destroy(GameObject.Find("lock_cloud_2").gameObject);
                    Destroy(GameObject.Find("lock_cloud_3").gameObject);
                    Destroy(GameObject.Find("lock_cloud_4").gameObject);
                    Destroy(GameObject.Find("lock_cloud_5").gameObject);
                    Destroy(GameObject.Find("lock_cloud_6").gameObject);
                    Destroy(GameObject.Find("lock_cloud_7").gameObject);
                    break;
                default:
                    Destroy(GameObject.Find("lock_cloud_2").gameObject);
                    Destroy(GameObject.Find("lock_cloud_3").gameObject);
                    Destroy(GameObject.Find("lock_cloud_4").gameObject);
                    Destroy(GameObject.Find("lock_cloud_5").gameObject);
                    Destroy(GameObject.Find("lock_cloud_6").gameObject);
                    Destroy(GameObject.Find("lock_cloud_7").gameObject);
                    break;

            }
        }
        catch(System.Exception ee)
        { }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Start Stage");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.name == "Chapter01" && GameManager.Chapter >= 1)
                {
                    GameManager.currentChapter = 1;
                    Application.LoadLevel("Level Menu 01");
                }
                else if (hit.collider.name == "Chapter02" && GameManager.Chapter >= 2)
                {
                    GameManager.currentChapter = 2;
                    Application.LoadLevel("Level Menu 02");
                }
                else if (hit.collider.name == "Chapter03" && GameManager.Chapter >= 3)
                {
                    GameManager.currentChapter = 3;
                    Application.LoadLevel("Level Menu 03");
                }
                else if (hit.collider.name == "Chapter04" && GameManager.Chapter >= 4)
                {
                    GameManager.currentChapter = 4;
                    Application.LoadLevel("Level Menu 04");
                }
                else if (hit.collider.name == "Chapter05" && GameManager.Chapter >= 5)
                {
                    GameManager.currentChapter = 5;
                    Application.LoadLevel("Level Menu 05");
                }
                else if (hit.collider.name == "Chapter06" && GameManager.Chapter >= 6)
                {
                    GameManager.currentChapter = 6;
                    Application.LoadLevel("Level Menu 06");
                }
                else if (hit.collider.name == "Chapter07" && GameManager.Chapter >= 7)
                {
                    GameManager.currentChapter = 7;
                    Application.LoadLevel("Level Menu 07");
                }
            }
        }
    }
}