using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_02 : MonoBehaviour
{
    //bool direction = true;
    float angle_02 = 0f;

    float c_angle_2 = 0;
    bool direction = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool can_rotate = p_00.can_rotate;

        float teta_1 = (float)p_01.c_angle_1;

        float teta_2 = (float)UI_script.teta_2;

        bool shoulder = UI_script.shoulder;

        Vector3 rotation_teta_2 = transform.rotation.eulerAngles;

        if (c_angle_2 < teta_2)
        {
            direction = true;
        }
        else
        {
            direction = false;
        }

        if (can_rotate)
        {
            if (Math.Abs(c_angle_2 - teta_2) > 0.5)
            {
                if (direction)
                {
                    c_angle_2 += 1f;

                }
                else
                {
                    c_angle_2 -= 1f;
                }
            }
            teta_2 = c_angle_2;
        }

        if (shoulder)
        {
            rotation_teta_2.z = teta_1 + teta_2;
        }
        else
        {
            rotation_teta_2.z = teta_1 - teta_2;
        }
        transform.rotation = Quaternion.Euler(rotation_teta_2);
    }
}