using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyro : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //ジャイロセンサの許可
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {

        //傾き情報を取得
        Quaternion q = Input.gyro.attitude;
        Quaternion qq = Quaternion.AngleAxis(-90.0f, Vector3.left);
        q.x *= -1.0f;
        q.y *= -1.0f;
        transform.localRotation = qq * q;
    }
}
