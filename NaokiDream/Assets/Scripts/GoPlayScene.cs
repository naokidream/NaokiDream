using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoPlayScene : MonoBehaviour {

    private string saveTime;
	// Use this for initialization
	void Start () {

        saveTime = SettingTime.getsavetimer();
        print(saveTime);
    }
	
	// Update is called once per frame
	void Update () {
        // 取得する値: 年
        var datetimeYeah = System.DateTime.Now.Year.ToString();
        // 取得する値: 月
        var datetimeMonth = System.DateTime.Now.Month.ToString();
        // 取得する値: 日
        var datetimeDay = System.DateTime.Now.Day.ToString();
        // 取得する値: 時
        var datetimeHour = System.DateTime.Now.Hour.ToString();
        // 取得する値: 分
        var datetimeMinute = System.DateTime.Now.Minute.ToString();
        // 取得する値: 秒
        var datetimeSecond = System.DateTime.Now.Second.ToString();

        var  datetimeStr = datetimeYeah + "/" + datetimeMonth + "/" + datetimeDay + " " + datetimeHour + ":" + datetimeMinute + ":" + datetimeSecond;

        if (saveTime == datetimeStr)
        {
            SceneManager.LoadScene("PlayScene");
        }
        else
        {
            print("時間じゃない" + datetimeStr);
        }
	}
}
