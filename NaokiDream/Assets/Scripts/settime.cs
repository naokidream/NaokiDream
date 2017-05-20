using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settime : MonoBehaviour {

    private string saveTime;

    // Use this for initialization
    void Start () {

        saveTime = SettingTime.getsavetimer();

        if(saveTime == null)
        {
            transform.GetComponent<Text>().text = "時間が設定されていません";
        }
        else
        {
            transform.GetComponent<Text>().text = saveTime;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
