using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform возвращает значение в виде Vector3, также transform можно присваивать свой Vector3

        // [координаты]
        Vector3 position = transform.position;
        //Vector3 position = transform.localPosition; это локальная позиция относительно родителя
        position.y = 100;
        transform.position = position;

        // [вращение]
        Vector3 rotation = transform.rotation.eulerAngles; // rotation работает в кватарнеонах, но мы переводим в градусы, т.к. нам удобнее
        rotation.y = 40f; // хз, зачем тут f, можно и без неё вроде как
        transform.rotation = Quaternion.Euler(rotation); // тут загоняем значение обратно в transform и поэтому переводим в кватарнеоны
                                                         // есть также localRotation (аналогично с position)

        // [размер (всегда локальный)]
        //transform.localScale = new Vector3(5f, 10f, 1f);

        // [другое]
        //transform.parent - что-то делает с родителем, хз
    }

    // Update is called once per frame
    void Update()
    {
        // [свойства]
        //transform.forward; - текущая позиция + метр вперёд 
        //transform.up; - текущая позиция + метр вверх
        //transform.right; - текущая позиция + метр вправо

        // [методы]
        // поворот вокруг оси -- [[ ось * градусы в секунду * чухня для кадров в секунду ]] --
        //transform.Rotate(transform.up * 360f * Time.deltaTime);

        // поворот вокруг произвольной оси -- [[ вокруг какой, по какой вроде,  сколько градусов в секунду * чухня для кадров]]
        //transform.RotateAround(Vector3.zero, Vector3.up, 20f * Time.deltaTime);

        // отключение всех дочерних объектов
        // transform.DetachChildren();

        // ищет дочерний transform по имени
        //Transform cam = transform.Find("Main Camera");
        //cam.position = Vector3.zero;

        // ищет дочерний transform по индексу
        //Transform cam = transform.GetChild(0);
        //cam.position = Vector3.zero;

        // проверяет, является ли transform(т.е. то, к чему скрипт прикреплён, ребёнком cam)
        //transform.IsChildOf(cam); // false
        //cam.IsChildOf(transform); // true

        //cam.GetSiblingIndex(); // выдаёт индекс в дереве
        //cam.SetAsFirstSibling(); // делает первым в списке, устанавливает индекс 0 по идее
        //cam.setAsLastSibling(); // делает последним в списке

        //transform.SetParent(); // установить родителя (на дочерних элементах не работает скоре всего)

        //transform.TransformPoint(); // переводит локальные координаты точки в глобальные
        //transform.TransformDirection(); // переводит локальные координаты вектора в глобальные

        //transform.InverseTransformPoint(); // переводит координаты точки из глобальных в локальные
        //transform.InverseTransformDirection(); // переводит координаты вектора из глобальных в локальные



        //transform.Translate(Vector3.forward * Time.deltaTime); - передвигает transform по вектору Vector3, но не относительно
        // мирового forward, а относительно forward локального, который находится в transform

        //transform.Translate(Vector3.forward * Time.deltaTime, Space.world); - тогда относительно глобального forward
        //transform.Translate(Vector3.forward * Time.deltaTime, Space.self); - по умолчанию ставится Space.self



        // СКРИПТ, КОТОРЫЙ Я ЗРЯ ПИСАЛ И ЕГО ОБИДНО УДАЛЯТЬ
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
