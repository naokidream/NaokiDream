using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Clock3D : MonoBehaviour {

    private string datetimeStr;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        datetimeStr = System.DateTime.Now.ToString();

        var text = gameObject.GetComponent<TextMesh>();
        //Debug.Log(redatetimeStr.Length);
        text.text = datetimeStr;
    }
}
