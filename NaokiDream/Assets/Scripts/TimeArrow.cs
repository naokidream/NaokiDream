using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeArrow : MonoBehaviour {

    public GameObject Time;
    


    public void monthUp()
    {
        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeMonth) >= 12)
        {
            time.datetimeMonth = "0";
        }
        else
        {
            var inc=int.Parse(time.datetimeMonth);
            inc++;
            time.datetimeMonth = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;
        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;
        
    }
    public void monthDown()
    {

        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeMonth) <= 0)
        {
            time.datetimeMonth = "12";
        }
        else
        {
            var inc = int.Parse(time.datetimeMonth);
            inc--;
            time.datetimeMonth = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;

        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;
    }
    public void yeahUp()
    {
        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeYeah) >= 9999)
        {
            time.datetimeYeah = "0";
        }
        else
        {
            var inc = int.Parse(time.datetimeYeah);
            inc++;
            time.datetimeYeah = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;
        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;

    }
    public void yeahDown()
    {

        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeYeah) <= 0)
        {
            time.datetimeYeah = "2017";
        }
        else
        {
            var inc = int.Parse(time.datetimeYeah);
            inc--;
            time.datetimeYeah = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;

        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;
    }


    public void DayUp()
    {
        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeDay) >= 31)
        {
            time.datetimeDay = "0";
        }
        else
        {
            var inc = int.Parse(time.datetimeDay);
            inc++;
            time.datetimeDay = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;
        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;

    }
    public void DayDown()
    {

        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeDay) <= 0 )
        {
            time.datetimeDay = "31";
        }
        else
        {
            var inc = int.Parse(time.datetimeDay);
            inc--;
            time.datetimeDay = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;

        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;
    }
    public void HourUp()
    {
        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeHour) >= 23)
        {
            time.datetimeHour = "0";
        }
        else
        {
            var inc = int.Parse(time.datetimeHour);
            inc++;
            time.datetimeHour = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;
        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;

    }
    public void HourDown()
    {

        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeHour) <= 0)
        {
            time.datetimeHour = "23";
        }
        else
        {
            var inc = int.Parse(time.datetimeHour);
            inc--;
            time.datetimeHour = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;

        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;
    }
    public void MinuteUp()
    {
        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeMinute) >= 60)
        {
            time.datetimeMinute = "0";
        }
        else
        {
            var inc = int.Parse(time.datetimeMinute);
            inc++;
            time.datetimeMinute = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;
        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;

    }
    public void MinuteDown()
    {

        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeMinute) <= 0)
        {
            time.datetimeMinute = "60";
        }
        else
        {
            var inc = int.Parse(time.datetimeMinute);
            inc--;
            time.datetimeMinute = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;

        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;
    }
    public void SecondeUp()
    {
        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeSecond) >= 60)
        {
            time.datetimeSecond = "0";
        }
        else
        {
            var inc = int.Parse(time.datetimeSecond);
            inc++;
            time.datetimeSecond = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;
        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;

    }
    public void SecondeDown()
    {

        var time = Time.GetComponent<alermSettings>();

        if (int.Parse(time.datetimeSecond) <= 0)
        {
            time.datetimeSecond = "60";
        }
        else
        {
            var inc = int.Parse(time.datetimeSecond);
            inc--;
            time.datetimeSecond = inc.ToString();
        }
        time.datetimeStr = time.datetimeYeah + "/" + time.datetimeMonth + "/" + time.datetimeDay + " " + time.datetimeHour + ":" + time.datetimeMinute + ":" + time.datetimeSecond;

        var text = Time.GetComponent<Text>();
        text.text = time.datetimeStr;
    }


}
