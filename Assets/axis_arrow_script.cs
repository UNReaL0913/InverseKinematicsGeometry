using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axis_arrow_script : MonoBehaviour
{
    public static float x;
    public static float y;
    public static float z;

    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = UI_script.camera_horizontal_velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        }
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }
}
