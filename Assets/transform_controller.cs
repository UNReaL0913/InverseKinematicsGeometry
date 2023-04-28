using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform ���������� �������� � ���� Vector3, ����� transform ����� ����������� ���� Vector3

        // [����������]
        Vector3 position = transform.position;
        //Vector3 position = transform.localPosition; ��� ��������� ������� ������������ ��������
        position.y = 100;
        transform.position = position;

        // [��������]
        Vector3 rotation = transform.rotation.eulerAngles; // rotation �������� � ������������, �� �� ��������� � �������, �.�. ��� �������
        rotation.y = 40f; // ��, ����� ��� f, ����� � ��� �� ����� ���
        transform.rotation = Quaternion.Euler(rotation); // ��� �������� �������� ������� � transform � ������� ��������� � �����������
                                                         // ���� ����� localRotation (���������� � position)

        // [������ (������ ���������)]
        //transform.localScale = new Vector3(5f, 10f, 1f);

        // [������]
        //transform.parent - ���-�� ������ � ���������, ��
    }

    // Update is called once per frame
    void Update()
    {
        // [��������]
        //transform.forward; - ������� ������� + ���� ����� 
        //transform.up; - ������� ������� + ���� �����
        //transform.right; - ������� ������� + ���� ������

        // [������]
        // ������� ������ ��� -- [[ ��� * ������� � ������� * ����� ��� ������ � ������� ]] --
        //transform.Rotate(transform.up * 360f * Time.deltaTime);

        // ������� ������ ������������ ��� -- [[ ������ �����, �� ����� �����,  ������� �������� � ������� * ����� ��� ������]]
        //transform.RotateAround(Vector3.zero, Vector3.up, 20f * Time.deltaTime);

        // ���������� ���� �������� ��������
        // transform.DetachChildren();

        // ���� �������� transform �� �����
        //Transform cam = transform.Find("Main Camera");
        //cam.position = Vector3.zero;

        // ���� �������� transform �� �������
        //Transform cam = transform.GetChild(0);
        //cam.position = Vector3.zero;

        // ���������, �������� �� transform(�.�. ��, � ���� ������ ���������, ������� cam)
        //transform.IsChildOf(cam); // false
        //cam.IsChildOf(transform); // true

        //cam.GetSiblingIndex(); // ����� ������ � ������
        //cam.SetAsFirstSibling(); // ������ ������ � ������, ������������� ������ 0 �� ����
        //cam.setAsLastSibling(); // ������ ��������� � ������

        //transform.SetParent(); // ���������� �������� (�� �������� ��������� �� �������� ����� �����)

        //transform.TransformPoint(); // ��������� ��������� ���������� ����� � ����������
        //transform.TransformDirection(); // ��������� ��������� ���������� ������� � ����������

        //transform.InverseTransformPoint(); // ��������� ���������� ����� �� ���������� � ���������
        //transform.InverseTransformDirection(); // ��������� ���������� ������� �� ���������� � ���������



        //transform.Translate(Vector3.forward * Time.deltaTime); - ����������� transform �� ������� Vector3, �� �� ������������
        // �������� forward, � ������������ forward ����������, ������� ��������� � transform

        //transform.Translate(Vector3.forward * Time.deltaTime, Space.world); - ����� ������������ ����������� forward
        //transform.Translate(Vector3.forward * Time.deltaTime, Space.self); - �� ��������� �������� Space.self



        // ������, ������� � ��� ����� � ��� ������ �������
        /*
         * 
        var x_input = uiDocument.rootVisualElement.Q<FloatField>(name: "x");
        double x=0;
        bool convert_flag_x = true;
        for (int i = 0; i < x_input.text.Length; i++)
        {
            if (x_input.text[i] == dot)
            {
                double celaya = Convert.ToDouble(x_input.text.Substring(0, i));
                string drob_str = x_input.text.Substring(i + 1);
                double drob = (Convert.ToDouble(drob_str)) / Math.Pow(10, drob_str.Length);

                x = celaya + drob;
                convert_flag_x = false;
                break;
            }
        }
        if (convert_flag_x)
        {
            x = Convert.ToDouble(x_input.text);
        }
        Debug.Log(x);
        */
    }
}
