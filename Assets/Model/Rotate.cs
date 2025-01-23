using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    

    bool isControl;
   
    void Update()
    {
        if (isControl)
        {
            transform.Rotate(0f, 20f * Time.deltaTime, 0f);
        }
       
    }
    public void Control()
    {
        isControl = !isControl;
    }
}
