using UnityEngine;
using System.Collections;

public class Chapter03Slider : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    private Vector3 prePosition;
    private bool gyro;
    private bool direction;
    // Use this for initialization
    void Start()
    {
        direction = false;

        prePosition = Vector3.zero;
        transform.position = new Vector3(transform.position.x, 1.657515f, transform.position.z);
        gyro = false;
        Time.timeScale = 1f;
        GameManager.time = 0f;
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
        if (!direction)
        {
            this.transform.position = new Vector2(transform.position.x + .03f, transform.position.y);
        }
        else if (direction)
        {
            this.transform.position = new Vector2(transform.position.x - .03f, transform.position.y);
        }
        if (this.transform.position.x > 4)
            direction = true;
        else if (this.transform.position.x < -4)
            direction = false;
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
                if (Input.mousePosition.y > prePosition.y)
                {
                    if (transform.position.y > 5.786173f)
                        return;
                    Debug.Log("up   " + prePosition.y + "    " + Input.mousePosition.y);
                    float dis = Input.mousePosition.y - prePosition.y;
                    transform.position = new Vector3(transform.position.x, transform.position.y + dis / 35, transform.position.z);
                }
                else if (Input.mousePosition.y < prePosition.y)
                {
                    if (transform.position.y < -6.841135f)
                        return;
                    Debug.Log("down   " + prePosition.y + "    " + Input.mousePosition.y);
                    float dis = Input.mousePosition.y - prePosition.y;
                    transform.position = new Vector3(transform.position.x, transform.position.y + dis / 35, transform.position.z);
                }
                prePosition = Input.mousePosition;
            }
        }
        else if (gyro)
        {


            Input.gyro.enabled = true;
            transform.position = new Vector3(transform.position.x, transform.position.y + Input.gyro.attitude.y, transform.position.z);


        }
    }
}
