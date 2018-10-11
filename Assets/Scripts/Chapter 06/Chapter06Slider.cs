using UnityEngine;
using System.Collections;

public class Chapter06Slider : MonoBehaviour {

    //private Ray ray;
    //private RaycastHit hit;
    private Vector3 prePosition;
    private bool gyro;
    public GameObject sliderLeft;
    public GameObject sliderRight;
    // Use this for initialization
    void Start()
    {
        GameManager.time = 0f;
        prePosition = Vector3.zero;
        gyro = false;

        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameManager.exit)
        {
            Time.timeScale = 0;
            Application.LoadLevelAdditive("Exit Page");
            GameManager.exit = true;
            Camera.main.aspect = 16f / 10f;
        
        }
        GameManager.time += Time.deltaTime;
    }
    void FixedUpdate()
    {
        if (!gyro)
        {

            /*if (Input.GetMouseButton(0))
            {   
                if (Input.mousePosition.x < Screen.width / 2)
                    sliderLeft.transform.position = new Vector3(sliderLeft.transform.position.x, sliderLeft.transform.position.y + dis / 35, sliderLeft.transform.position.z);
                if (Input.mousePosition.x > Screen.width / 2)
                    sliderRight.transform.position = new Vector3(sliderRight.transform.position.x, sliderRight.transform.position.y + dis / 35, sliderRight.transform.position.z);

                prePosition = Input.mousePosition;


            }*/
            if (Input.touchCount > 0)
            {
                Touch t = Input.GetTouch(0);
                if(t.position.x > Screen.width / 2)
                {
                    sliderRight.transform.position = new Vector2(sliderRight.transform.position.x, sliderRight.transform.position.y + t.deltaPosition.y / 17);
                }
                else if(t.position.x < Screen.width / 2)
                {
                    sliderLeft.transform.position = new Vector2(sliderLeft.transform.position.x, sliderLeft.transform.position.y + t.deltaPosition.y / 17);
                }
                if(Input.touchCount > 1)
                {
                    Touch t1 = Input.GetTouch(1);
                    if (t1.position.x > Screen.width / 2)
                    {
                        sliderRight.transform.position = new Vector2(sliderRight.transform.position.x, sliderRight.transform.position.y + t1.deltaPosition.y / 17);
                    }
                    else if (t1.position.x < Screen.width / 2)
                    {
                        sliderLeft.transform.position = new Vector2(sliderLeft.transform.position.x, sliderLeft.transform.position.y + t1.deltaPosition.y / 17);
                    }
                }
            }
            if (sliderLeft.transform.position.y > 5.786173f)
                sliderLeft.transform.position = new Vector3(sliderLeft.transform.position.x, 5.786173f, sliderLeft.transform.position.z);
            if (sliderLeft.transform.position.y < -6.841135f)
                sliderLeft.transform.position = new Vector3(sliderLeft.transform.position.x, -6.841135f, sliderLeft.transform.position.z);
            if (sliderRight.transform.position.y > 5.786173f)
                sliderRight.transform.position = new Vector3(sliderRight.transform.position.x, 5.786173f, sliderRight.transform.position.z);
            if (sliderRight.transform.position.y < -6.841135f)
                sliderRight.transform.position = new Vector3(sliderRight.transform.position.x, -6.841135f, sliderRight.transform.position.z);
        }
        /*else if (gyro)
        {


            Input.gyro.enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y + Input.gyro.attitude.y, transform.position.z);


        }*/
    }
}