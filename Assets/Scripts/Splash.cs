using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //StartCoroutine (t());
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimateFruitBox.x <= 0)
            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel("Start Stage");
            }
    }
    //IEnumerator t ()
    //	{
    //yield return new WaitForSeconds(3f);
    //  Application.LoadLevel("Start Stage");
    //}
}
