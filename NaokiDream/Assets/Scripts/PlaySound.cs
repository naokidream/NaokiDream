using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    private float _time;

    [SerializeField]
    private float _maxTime = 5.0f;

    [SerializeField]
    private AudioClip[] _voices;

    private int _voiceNumber;

	// Use this for initialization
	void Start () {
        _time = _maxTime;
	}
	
	// Update is called once per frame
	void Update () {

        _time -= Time.deltaTime;
		
        if(_time<0)
        {
            GetComponent<AudioSource>().PlayOneShot(_voices[0]);
            _time = _maxTime;
        }

	}
}
