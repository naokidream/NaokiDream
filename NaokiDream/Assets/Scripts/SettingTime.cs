using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingTime : MonoBehaviour {


    public GameObject settimer;

    public static string savetimer;

	// Use this for initialization
	public void SaveTime() {

        savetimer = settimer.GetComponent<alermSettings>().datetimeStr;
        print(savetimer);

	}
	public static string getsavetimer()
    {
        return savetimer;
    } 
	// Update is called once per frame
	void Update () {
		
	}
}
