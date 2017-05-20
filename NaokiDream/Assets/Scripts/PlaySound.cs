using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    private float _time;

    [SerializeField]
    private float _maxTime = 8.0f;

    [SerializeField]
    private AudioClip[] _voices;
    
    public int voiceNumber;

    private int _wakeUpNumber;

	// Use this for initialization
	void Start () {
        _time = _maxTime;
        voiceNumber = 0;
        _wakeUpNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {

        _time -= Time.deltaTime;
		
        if(_time<0)
        {
            if (voiceNumber < _voices.Length)
            {
                //「起きて」以外の再生
                if (voiceNumber >= 4)
                {
                    //音声の再生
                    GetComponent<AudioSource>().PlayOneShot(_voices[voiceNumber]);
                    voiceNumber = 0;
                }
                //「起きて」の再生
                else
                {
                    //1週したら初期化
                    if (_wakeUpNumber > 3)
                        _wakeUpNumber = 0;
                    //「起きて」のループ
                    GetComponent<AudioSource>().PlayOneShot(_voices[_wakeUpNumber]);
                    _wakeUpNumber++;
                }
                _time = _maxTime;
            }
        }
	}
}
