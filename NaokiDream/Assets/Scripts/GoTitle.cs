using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoTitle : MonoBehaviour {

    private bool _flag = false;

    private float _time = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GetComponent<PlaySound>().voiceNumber == 6)
        {
            _flag = true;
        }

        if(_flag)
        {
            _time -= Time.deltaTime;
            if (_time < 0)
                SceneManager.LoadScene("Title");

        }
    }
}
