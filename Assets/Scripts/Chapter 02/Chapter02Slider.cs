using UnityEngine;
using System.Collections;

public class Chapter02Slider : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    private Vector3 prePosition;
    private bool gyro;
    private int first = 0;
    private int other = 0;
    
    void Start()
    {
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
                    
                    float dis = Input.mousePosition.y - prePosition.y;
                    transform.position = new Vector3(transform.position.x, transform.position.y + dis / 35, transform.position.z);
                }
                else if (Input.mousePosition.y < prePosition.y)
                {
                    if (transform.position.y < -6.841135f)
                        return;
                    
                    float dis = Input.mousePosition.y - prePosition.y;
                    transform.position = new Vector3(transform.position.x, transform.position.y + dis / 35, transform.position.z);
                }
                prePosition = Input.mousePosition;
            }
        }
        else if (gyro)
        {

            if (first == 0)
            {
                Input.gyro.enabled = true;
                Input.gyro.updateInterval = 0.02f;
                first = Mathf.Abs((int)(Input.gyro.attitude.y * 100));
                return;
            }
            other = (int)(Input.gyro.attitude.y * 100);
            float result = first - Mathf.Abs(other);
            if (result > 10)
                result = 10;
            this.transform.Translate(new Vector3(0, result / 40, 0));
            if (transform.position.y < -6.841135f)
                transform.position = new Vector3(transform.position.x, -6.841135f, transform.position.z);
            if (transform.position.y > 5.786173f)
                transform.position = new Vector3(transform.position.x, 5.786173f, transform.position.z);

        }
    }
}
