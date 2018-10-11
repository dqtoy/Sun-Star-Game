using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int ballLsCount = 2;
	public static float score = 0.0f;
	public static int level1 = 7;
    public static int level2 = 7;
    public static int level3 = 7;
    public static int level4 = 7;
    public static int level5 = 7;
    public static int level6 = 7;
    public static int level7 = 7;
    public static int level = 1;
	public static int Chapter = 1;
    public static float time = 0;
    public static bool exit = false;
    public static float rotationSpeed = 2f;

    public static int currentChapter = 1;

    public static void OffSound()
    {
        GameObject sound = GameObject.Find("Sound") as GameObject;
        sound.GetComponent<AudioSource>().volume = 0;
    }
    public static void OnSound()
    {
        GameObject sound = GameObject.Find("Sound") as GameObject;
        sound.GetComponent<AudioSource>().volume = 1;
    }
}
