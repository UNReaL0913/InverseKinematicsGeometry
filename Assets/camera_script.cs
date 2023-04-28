using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    float speed_h;
    float speed_v;

    float vertical_angles;

    // Start is called before the first frame update
    void Start()
    {
        speed_h = UI_script.camera_horizontal_velocity;
        speed_v = UI_script.camera_vertical_velocity;
    }

    // Update is called once per frame
    void Update()
    {
        // поворот вокруг произвольной оси -- [[ вокруг какой, по какой вроде,  сколько градусов в секунду * чухня для кадров]]
        //transform.RotateAround(Vector3.zero, Vector3.up, 20f * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, -speed_h * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, speed_h * Time.deltaTime);
        }
        //Debug.Log(transform.rotation.eulerAngles.x);
        /*if((transform.rotation.eulerAngles.x <= 50f && transform.rotation.eulerAngles.x >= 0f) || (transform.rotation.eulerAngles.x <= 360f && transform.rotation.eulerAngles.x >= 350f))
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.RotateAround(Vector3.zero, new Vector3(axis_arrow_script.x - axis_script.x, axis_arrow_script.y - axis_script.y, axis_arrow_script.z - axis_script.z), speed_v * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.RotateAround(Vector3.zero, new Vector3(axis_arrow_script.x - axis_script.x, axis_arrow_script.y - axis_script.y, axis_arrow_script.z - axis_script.z), -speed_v * Time.deltaTime);
            }
        }
        */
        if (Input.GetKey(KeyCode.W))
        {
            transform.RotateAround(Vector3.zero, new Vector3(axis_arrow_script.x - axis_script.x, axis_arrow_script.y - axis_script.y, axis_arrow_script.z - axis_script.z), -speed_v * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.RotateAround(Vector3.zero, new Vector3(axis_arrow_script.x - axis_script.x, axis_arrow_script.y - axis_script.y, axis_arrow_script.z - axis_script.z), speed_v * Time.deltaTime);
        }
    }
}
