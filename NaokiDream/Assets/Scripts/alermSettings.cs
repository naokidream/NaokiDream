using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alermSettings : MonoBehaviour {

    public string datetimeStr;

    public string datetimeYeah;
    public string datetimeMonth;
    public string datetimeDay;
    public string datetimeHour;
    public string datetimeMinute;
    public string datetimeSecond;

    // Use this for initialization
    void Start () {

        // 取得する値: 年
        datetimeYeah = System.DateTime.Now.Year.ToString();
        // 取得する値: 月
        datetimeMonth = System.DateTime.Now.Month.ToString();
        // 取得する値: 日
        datetimeDay = System.DateTime.Now.Day.ToString();
        // 取得する値: 時
        datetimeHour = System.DateTime.Now.Hour.ToString();
        // 取得する値: 分
        datetimeMinute = System.DateTime.Now.Minute.ToString();
        // 取得する値: 秒
        datetimeSecond = System.DateTime.Now.Second.ToString();

        datetimeStr = datetimeYeah + "/" + datetimeMonth + "/" + datetimeDay + " " + datetimeHour + ":" + datetimeMinute + ":" + datetimeSecond;

        //datetimeStr = System.DateTime.Now.ToString();

        var text = gameObject.GetComponent<Text>();
        text.text = datetimeStr;


    }
	
	// Update is called once per frame
	void Update () {
    }
}
