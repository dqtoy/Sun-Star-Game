using UnityEngine;
using System.Collections;

public class Chapter04Slider : MonoBehaviour {


    private Ray ray;
    private RaycastHit hit;
    private Vector3 prePosition;
    private bool gyro;
    // Use this for initialization
    void Start()
    {
        GameManager.time = 0f;
        prePosition = Vector3.zero;
        transform.position = new Vector3(transform.position.x, 1.657515f, transform.position.z);
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
            if (Input.GetMouseButtonDown(0))
                prePosition = Vector3.zero;
            if (Input.GetMouseButton(0))
            {
                if (prePosition == Vector3.zero)
                {
                    prePosition = Input.mousePosition;
                    return;
                }
                if (prePosition == Input.mousePosition)
                    return;



                //Debug.Log("down   " + prePosition.y + "    " + Input.mousePosition.y);
                float disy = Input.mousePosition.y - prePosition.y;
                float disx = Input.mousePosition.x - prePosition.x;
                if (disx < -7)
                    disx = -7;
                if (disy < -12)
                    disy = -12;
                if (disx > 7)
                    disx = 7;
                if (disy > 12)
                    disy = 12;
                transform.position = new Vector3(transform.position.x + disx / 35, transform.position.y + disy / 35, transform.position.z);




                prePosition = Input.mousePosition;
            }
            if (transform.position.y > 5.786173f)
                transform.position = new Vector3(transform.position.x, 5.786173f, transform.position.z);
            if (transform.position.x > 2.0f)
                transform.position = new Vector3(2.0f, transform.position.y, transform.position.z);
            if (transform.position.y < -6.841135f)
                transform.position = new Vector3(transform.position.x, -6.841135f, transform.position.z);
            if (transform.position.x < -2.0f)
                transform.position = new Vector3(-2.0f, transform.position.y, transform.position.z);
        }
        else if (gyro)
        {


            Input.gyro.enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y + Input.gyro.attitude.y, transform.position.z);


        }
    }
}
