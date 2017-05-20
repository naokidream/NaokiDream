using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour {

    // Use this for initialization
    public void GoTitle(){
        SceneManager.LoadScene("Title");
    }
    public void GoSetting()
    {
        SceneManager.LoadScene("Setting");
    }
    private string saveTime;
    public void GoWait()
    {
        saveTime = SettingTime.getsavetimer();
        //print(saveTime);
        if (saveTime != null)
        {
            SceneManager.LoadScene("Wait");
        }
    }

}
