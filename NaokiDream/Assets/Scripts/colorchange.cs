using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorchange : MonoBehaviour {

    private string saveTime;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        saveTime = SettingTime.getsavetimer();
        //print(saveTime);
        if (saveTime == null)
        {
            gameObject.transform.GetComponent<Image>().color = new Color(0,0,0);
        }

    }
}
