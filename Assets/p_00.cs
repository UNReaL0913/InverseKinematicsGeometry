using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class p_00 : MonoBehaviour
{
    float angle_00 = 0f;
    bool direction = true;
    float c_angle = 0;

    public static bool can_rotate = false;

    float x = UI_script.x;
    float z = UI_script.z;

    float x_l;
    float z_l;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        float teta_0 = (float)UI_script.teta_0;

        bool direction = true;
        // true - ïðîòèâ ÷àñîâîé
        // false - ïî ÷àñîâîé

        x_l = cursor_script.x_l;
        z_l = cursor_script.z_l;

        Vector3 rotation_teta_0 = transform.rotation.eulerAngles;

        if (teta_0 <= 170 && teta_0 >= -170)
        {
            if (z_l == 0f && x_l < 0f)
            {
                can_rotate = false;
            }
            else
            {
                can_rotate = true;
            }


            // ÑÈÑÒÅÌÀ DIRECTION ÍÀ×ÀËÎ
            if (c_angle >= 0 && teta_0 > 0)
            {
                if (teta_0 > c_angle)
                {
                    direction = true;
                }
                else
                {
                    direction = false;
                }
            }

            if (c_angle < 0 && teta_0 > 0)
            {
                direction = true;
            }

            if (c_angle > 0 && teta_0 < 0)
            {
                direction = false;
            }

            if (c_angle <= 0 && teta_0 < 0)
            {
                if (teta_0 < c_angle)
                {
                    direction = false;
                }
                else
                {
                    direction = true;
                }
            }
            if (c_angle > 0 && teta_0 == 0)
            {
                direction = false;
            }

            if (c_angle < 0 && teta_0 == 0)
            {
                direction = true;
            }
            // ÑÈÑÒÅÌÀ DIRECTION ÊÎÍÅÖ

            Debug.Log("can_rotate " + can_rotate);
            
            if (can_rotate)
            {
                if (Math.Abs(c_angle - teta_0) > 0.5)
                {
                    if (direction)
                    {
                        c_angle += 1f;

                    }
                    else
                    {
                        c_angle -= 1f;
                    }
                }
                rotation_teta_0.y = c_angle;
            }
        }
        
        
        if( (teta_0 < 180 && teta_0 > 170) || (teta_0 > -180 && teta_0 < -170) )
        {
            can_rotate = false;
        }

        Debug.Log("can_rotate " + can_rotate);
        Debug.Log("óãîë teta_0 " + teta_0);

        transform.rotation = Quaternion.Euler(rotation_teta_0);
    }
}