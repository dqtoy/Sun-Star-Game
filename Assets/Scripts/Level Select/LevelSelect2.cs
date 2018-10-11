using UnityEngine;
using System.Collections;

public class LevelSelect2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameManager.level2 = PlayerPrefs.GetInt("chapter02_level", 1);
    }

    // Update is called once per frame
    void Update()
    {

        try
        {
            switch (GameManager.level2)
            {
                case 1:
                    break;
                case 2:

                    Destroy(GameObject.Find("block_cloud_levels_22").gameObject);
                    break;
                case 3:
                    Destroy(GameObject.Find("block_cloud_levels_22").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_23").gameObject);
                    break;
                case 4:
                    Destroy(GameObject.Find("block_cloud_levels_22").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_23").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_24").gameObject);
                    break;
                case 5:
                    Destroy(GameObject.Find("block_cloud_levels_22").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_23").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_24").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_25").gameObject);
                    break;
                case 6:
                    Destroy(GameObject.Find("block_cloud_levels_22").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_23").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_24").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_25").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_26").gameObject);
                    break;
                case 7:
                    Destroy(GameObject.Find("block_cloud_levels_22").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_23").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_24").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_25").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_26").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_27").gameObject);
                    break;
                default:
                    Destroy(GameObject.Find("block_cloud_levels_22").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_23").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_24").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_25").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_26").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_27").gameObject);
                    break;

            }
        }
        catch (System.Exception ee)
        { }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("ChaptersPage");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            if (hit.collider != null)
            {
                GameManager.OffSound();
                if (hit.collider.name == "Level01" && GameManager.level2 >= 1)
                {
                    GameManager.level2 = 1;
                    GameManager.ballLsCount = 3;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level02" && GameManager.level2 >= 2)
                {
                    GameManager.level2 = 2;
                    GameManager.ballLsCount = 4;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level03" && GameManager.level2 >= 3)
                {
                    GameManager.level2 = 3;
                    GameManager.ballLsCount = 5;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level04" && GameManager.level2 >= 4)
                {
                    GameManager.level2 = 4;
                    GameManager.ballLsCount = 6;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level05" && GameManager.level2 >= 5)
                {
                    GameManager.level2 = 5;
                    GameManager.ballLsCount = 7;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level06" && GameManager.level2 >= 6)
                {
                    GameManager.level2 = 6;
                    GameManager.ballLsCount = 8;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level07" && GameManager.level2 >= 7)
                {
                    GameManager.level2 = 7;
                    GameManager.ballLsCount = 10;
                    Application.LoadLevel(selectLevel());
                }
            }
        }
    }
    private string selectLevel()
    {
        int x = Random.Range(1, 11);
        return "Chapter02Stage0" + x;
    }
}
