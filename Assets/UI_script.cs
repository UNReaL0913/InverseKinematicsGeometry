using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI_script : MonoBehaviour
{
    public static bool shoulder = false; // true - down, false - up

    public static float camera_vertical_velocity = 70;
    public static float camera_horizontal_velocity = 150;

    Button rotate_00;
    Button rotate_01;
    Button rotate_02;

    Button calculate;

    Transform vector_platform;

    public static double teta_0 = 0; // градус 1 поворотного звена p_00
    public static double teta_1 = 0; // градус 2 поворотного звена p_01
    public static double teta_2 = 0; // градус 3 поворотного звена p_02

    const float a_1 = 269.3f;   // первое плечо
    const float a_2 = 383.37f;  // второе плечо

    public static float x;
    public static float y;
    public static float z;

    bool can_rotate = false;
    bool flag = false;

    float r;
    float f1;
    float f2;
    float f3;

    void OnEnable()
    {
        Debug.Log(teta_0);
        // назначение кнопки calculate

        var uiDocument = GetComponent<UIDocument>();

        calculate = uiDocument.rootVisualElement.Q<Button>("calculate");
        calculate.RegisterCallback<ClickEvent>(InverseKinematicProgram);
    }



    void Update()
    {
        can_rotate = p_00.can_rotate;
    }

    void InverseKinematicProgram(ClickEvent e)
    {
        var uiDocument = GetComponent<UIDocument>();

        var x_input = uiDocument.rootVisualElement.Q<FloatField>(name: "x");
        var y_input = uiDocument.rootVisualElement.Q<FloatField>(name: "y");
        var z_input = uiDocument.rootVisualElement.Q<FloatField>(name: "z");

        x = x_input.value;
        y = y_input.value;
        z = z_input.value;

        if (((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) > Math.Pow(635, 2)) || ((y > -650) && (y < 50) && (Math.Pow(x, 2) + Math.Pow(z, 2) < Math.Pow(150, 2)))
            || ((x * x) / (225 * 225) + (y * y) / (150 * 150) + (z * z) / (225 * 225)) <= 1))
        {
            uiDocument.rootVisualElement.Q<Label>("label_error").text = "Вне зоны действия!";
            flag = false;
        }
        else
        {
            uiDocument.rootVisualElement.Q<Label>("label_error").text = "Корректно";
            flag = true;
            // расчёт угла teta_0 горизонтального поворотного звена p_00
            if (x != 0)
            {
                if (x > 0 && z > 0)
                {
                    teta_0 = (float)((Math.Atan(z / x) * 180) / 3.14);
                }

                if (x < 0 && z < 0)
                {
                    teta_0 = -180 + (float)((Math.Atan(z / x) * 180) / 3.14);
                }

                if (x > 0 && z < 0)
                {
                    teta_0 = (float)((Math.Atan(z / x) * 180) / 3.14);
                }

                if (x < 0 && z > 0)
                {
                    teta_0 = 180 + (float)((Math.Atan(z / x) * 180) / 3.14);
                }
                if (z == 0)
                {
                    teta_0 = 0f;
                }
            }
        }




        if (can_rotate == false)
        {
            uiDocument.rootVisualElement.Q<Label>("label_error").text = "Блокировка угла teta_0!";
        }
        else
        {
            if (x != 0 && flag)
            {  
                r = (float)Math.Sqrt(Math.Pow(50.2f + x * Math.Cos(teta_0 * 3.14 / 180) + z * Math.Sin(teta_0 * 3.14 / 180), 2) + Math.Pow(y, 2));

                f1 = (float)((Math.Acos((Math.Pow(r, 2) + Math.Pow(a_1, 2) - Math.Pow(a_2, 2)) / (2 * r * a_1)) * 180) / 3.14);


                f2 = (float)((Math.Asin(y / r) * 180) / 3.14);

                f3 = (float)(((Math.Acos((Math.Pow(a_1, 2) + Math.Pow(a_2, 2) - Math.Pow(r, 2)) / (2 * a_1 * a_2))) * 180) / 3.14);

                if (shoulder)
                {
                    teta_1 = (f2 - f1);
                    teta_2 = (180f - f3 - 7);
                }
                else
                {
                    teta_1 = (f1 + f2);
                    teta_2 = (180f - f3 + 7);
                }
            }
        }
    }
}