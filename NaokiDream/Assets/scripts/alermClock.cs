using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alermClock : MonoBehaviour {

    private string datetimeStr;
    void Update()
    {
        datetimeStr = System.DateTime.Now.ToString();
        var text = gameObject.GetComponent<Text>();
        //Debug.Log(redatetimeStr.Length);
        text.text = datetimeStr;
    }
}
