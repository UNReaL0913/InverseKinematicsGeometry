using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor_script : MonoBehaviour
{
    
    public static float x_l;
    public static float z_l;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = UI_script.x;
        float y = UI_script.y;
        float z = UI_script.z;

        transform.localPosition = new Vector3(x, y, -z);

        x_l = transform.localPosition.x;
        z_l = transform.localPosition.z;

        //Debug.Log("x_l cursor = " + x_l);
        //Debug.Log("z_l cursor = " + z_l);
        /*
        x_l = transform.position.x;
        y_l = transform.position.y - ;
        z_l = transform.position.z;
        */
    }
}
