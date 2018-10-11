using UnityEngine;
using System.Collections;

public class Chapter06ObjectMovement : MonoBehaviour {

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
    public GameObject sliderLeft;
    public GameObject sliderRight;
    private bool START = false;
    public GameObject startTimer;
    private GameObject cloneStartTimer;
    public GameObject help;
    private bool A = true;
    // Use this for initialization
    void Start()
    {
        ballsCount = GameManager.ballLsCount;
        cloneStartTimer = Instantiate(startTimer, new Vector3(0, 0, -3), transform.rotation) as GameObject;
        redBallClones = new GameObject[ballsCount];
        blueBallClones = new GameObject[ballsCount];
        for (int i = 0; i < ballsCount; i++)
        {
            float x1;
            if (i % 2 == 0)
                x1 = Random.Range(1.0f, 6.0f);
            else
                x1 = Random.Range(-1.0f, -6.0f);
            redBallClones[i] = Instantiate(redBallObject, new Vector3(x1, Random.Range(2f, -2f), -2), transform.rotation) as GameObject;
            //redBallClones[i].rigidbody2D.AddForce(4,4,ForceMode.Impulse);
           // redBallClones[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 40), ForceMode2D.Impulse);

            float x2;
            if (i % 2 == 0)
                x2 = Random.Range(1.0f, 6.0f);
            else
                x2 = Random.Range(-1.0f, -6.0f);

            blueBallClones[i] = Instantiate(blueBallObject, new Vector3(x2, Random.Range(2f, -2f), -2), transform.rotation) as GameObject;
            //redBallClones[i].rigidbody2D.AddForce(4,4,ForceMode.Impulse);
            //blueBallClones[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 40), ForceMode2D.Impulse);
        }
        StartCoroutine(myTimer());

    }


    IEnumerator myTimer()
    {
        GameObject hh = null;
        if(GameManager.level6 <= 1)
            hh = Instantiate(help, new Vector3(0, 0, -3), transform.rotation) as GameObject;
        yield return new WaitForSeconds(6.5f);
        if (GameManager.level6 <= 1)
            Destroy(hh.gameObject);
        START = true;
        Destroy(cloneStartTimer.gameObject);
        for (int i = 0; i < ballsCount; i++)
        {
            redBallClones[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 40), ForceMode2D.Impulse);
            blueBallClones[i].GetComponent<Rigidbody2D>().AddForce(new Vector2(40, 40), ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ballsCount; i++)
        {
            redBallClones[i].transform.Rotate(new Vector3(0, 0, GameManager.rotationSpeed));
            blueBallClones[i].transform.Rotate(new Vector3(0, 0, GameManager.rotationSpeed));
        }
        if (START)
        {
            if (position)
            {
                for (int i = 0; i < ballsCount; i++)
                {
                    if (redBallClones[i].transform.position.x > sliderRight.transform.position.x)
                        red++;
                    if (blueBallClones[i].transform.position.x < sliderLeft.transform.position.x)
                        blue++;
                }


            }
            else
            {
                for (int i = 0; i < ballsCount; i++)
                {
                    if (redBallClones[i].transform.position.x < sliderLeft.transform.position.x)
                        red++;
                    if (blueBallClones[i].transform.position.x > sliderRight.transform.position.x)
                        blue++;
                }

            }
            if (red == ballsCount && blue == ballsCount)
            {
                if (A)
                {
                    Timer t = GetComponent<Timer>(); StartCoroutine(Delay());
                    Application.LoadLevelAdditive("FinishPage");
                    Camera.main.aspect = 16f / 10f;
                    
                    A = false;
                }
            }

            red = 0;
            blue = 0;
            for (int i = 0; i < ballsCount; i++)
            {
                if (redBallClones[i].transform.position.x < 0)
                    red++;
                if (blueBallClones[i].transform.position.x < 0)
                    blue++;
            }
            if (red > blue)
                position = false;
            else
                position = true;
            red = 0;
            blue = 0;
            for (int i = 0; i < ballsCount; i++)
            {
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
    }



    void SetScore
        (float f)
    {

    }
    IEnumerator Delay()
    {

        //nextLevel = true;
        yield return new WaitForSeconds(5f);
        switch (GameManager.level6)
        {
            case 1:
                GameManager.ballLsCount = 4;
                if (PlayerPrefs.GetInt("chapter06_level") < GameManager.level6 + 1)
                {
                    PlayerPrefs.SetInt("chapter06_level", GameManager.level6 + 1);
                    PlayerPrefs.Save();
                } break;
            case 2:
                GameManager.ballLsCount = 5;
                if (PlayerPrefs.GetInt("chapter06_level") < GameManager.level6 + 1)
                {
                    PlayerPrefs.SetInt("chapter06_level", GameManager.level6 + 1);
                    PlayerPrefs.Save();
                } break;
            case 3:
                GameManager.ballLsCount = 6;
                if (PlayerPrefs.GetInt("chapter06_level") < GameManager.level6 + 1)
                {
                    PlayerPrefs.SetInt("chapter06_level", GameManager.level6 + 1);
                    PlayerPrefs.Save();
                } break;

            case 4:
                GameManager.ballLsCount = 7;
                if (PlayerPrefs.GetInt("chapter06_level") < GameManager.level6 + 1)
                {
                    PlayerPrefs.SetInt("chapter06_level", GameManager.level6 + 1);
                    PlayerPrefs.Save();
                } break;

            case 5:
                GameManager.ballLsCount = 8;
                if (PlayerPrefs.GetInt("chapter06_level") < GameManager.level6 + 1)
                {
                    PlayerPrefs.SetInt("chapter06_level", GameManager.level6 + 1);
                    PlayerPrefs.Save();
                } break;
            case 6:
                GameManager.ballLsCount = 10;
                if (PlayerPrefs.GetInt("chapter06_level") < GameManager.level6 + 1)
                {
                    PlayerPrefs.SetInt("chapter06_level", GameManager.level6 + 1);
                    PlayerPrefs.Save();
                } break;
        }
        switch (GameManager.level6)
        {

            case 1:
            case 2:


            case 3:


            case 4:


            case 5:

            case 6:
                Application.LoadLevel("Chapter06Stage0" + (Random.Range(1, 11)));
                break;

            case 7:
                GameManager.ballLsCount = 3;
                if (PlayerPrefs.GetInt("Chapter") < GameManager.Chapter + 1)
                {
                    GameManager.Chapter = GameManager.Chapter + 1;
                    PlayerPrefs.SetInt("Chapter", GameManager.Chapter);
                    PlayerPrefs.Save();
                }
                Application.LoadLevel("Level Menu 07");
                break;
        }
        GameManager.level++;
        GameManager.level6++;


    }
    /*void OnGUI()
    {
        GUIStyle guiStyle = new GUIStyle();
        guiStyle.fontSize = 60;
        guiStyle.normal.textColor = Color.white;
        GUILayout.BeginHorizontal();
        if (nextLevel)
            GUI.TextField(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 20, 80, 40), "Level" + (GameManager.level + 1), guiStyle);
        GUILayout.EndHorizontal();
    }
     * */
}