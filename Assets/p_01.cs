using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_01 : MonoBehaviour
{
    public static float angle_01 = 0f;

    public static float c_angle_1 = 0;
    bool direction = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool can_rotate = p_00.can_rotate;

        float teta_1 = (float)UI_script.teta_1;

        Vector3 rotation_teta_1 = transform.rotation.eulerAngles;

        if(c_angle_1 < teta_1)
        {
            direction = true;
        }
        else
        {
            direction = false;
        }

        if (can_rotate)
        {
            if (Math.Abs(c_angle_1 - teta_1) > 0.5)
            {
                if (direction)
                {
                    c_angle_1 += 1f;

                }
                else
                {
                    c_angle_1 -= 1f;
                }
            }
            rotation_teta_1.z = c_angle_1;
        }
        transform.rotation = Quaternion.Euler(rotation_teta_1);
    }
}
