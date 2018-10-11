﻿using UnityEngine;
using System.Collections;

public class LevelSelect1 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameManager.level1 = PlayerPrefs.GetInt("chapter01_level", 1);
    }

    // Update is called once per frame
    void Update()
    {

        try
        {
            switch (GameManager.level1)
            {
                case 1:
                    break;
                case 2:
                    
                    Destroy(GameObject.Find("block_cloud_levels_2").gameObject);
                    break;
                case 3:
                    Destroy(GameObject.Find("block_cloud_levels_2").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_3").gameObject);
                    break;
                case 4:
                    Destroy(GameObject.Find("block_cloud_levels_2").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_3").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_4").gameObject);
                    break;
                case 5:
                    Destroy(GameObject.Find("block_cloud_levels_2").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_3").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_4").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_5").gameObject);
                    break;
                case 6:
                    Destroy(GameObject.Find("block_cloud_levels_2").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_3").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_4").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_5").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_6").gameObject);
                    break;
                case 7:
                    Destroy(GameObject.Find("block_cloud_levels_2").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_3").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_4").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_5").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_6").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_7").gameObject);
                    break;
                default:
                    Destroy(GameObject.Find("block_cloud_levels_2").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_3").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_4").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_5").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_6").gameObject);
                    Destroy(GameObject.Find("block_cloud_levels_7").gameObject);
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

                if (hit.collider.name == "Level01" && GameManager.level1 >= 1)
                {
                    GameManager.level1 = 1;
                    GameManager.ballLsCount = 3;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level02" && GameManager.level1 >= 2)
                {
                    GameManager.level1 = 2;
                    GameManager.ballLsCount = 4;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level03" && GameManager.level1 >= 3)
                {
                    GameManager.level1 = 3;
                    GameManager.ballLsCount = 5;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level04" && GameManager.level1 >= 4)
                {
                    GameManager.level1 = 4;
                    GameManager.ballLsCount = 6;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level05" && GameManager.level1 >= 5)
                {
                    GameManager.level1 = 5;
                    GameManager.ballLsCount = 7;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level06" && GameManager.level1 >= 6)
                {
                    GameManager.level1 = 6;
                    GameManager.ballLsCount = 8;
                    Application.LoadLevel(selectLevel());
                }
                else if (hit.collider.name == "Level07" && GameManager.level1 >= 7)
                {
                    GameManager.level1 = 7;
                    GameManager.ballLsCount = 10;
                    Application.LoadLevel(selectLevel());
                }
            }
        }
    }
    private string selectLevel()
    {
        int x = Random.Range(1, 11);
        return "Chapter01Stage0" + x;
    }
}
