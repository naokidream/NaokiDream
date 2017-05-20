using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alermClock : MonoBehaviour {

    private string datetimeStr;
    void Update()
    {
        datetimeStr = System.DateTime.Now.ToString();
        Debug.Log(datetimeStr);
    }
}
