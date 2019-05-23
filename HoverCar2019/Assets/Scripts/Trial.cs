using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trial : MonoBehaviour 
{
    private void Start()
    {
        float source = 130.1234567f;
        float f = (float)(source - Math.Truncate(source));
        int i = (int)(f * 1000);
        Debug.Log(i);
    }
}
