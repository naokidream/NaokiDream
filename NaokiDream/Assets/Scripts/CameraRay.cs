using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraRay : MonoBehaviour {


    private Ray ray;

    [SerializeField]
    private GameObject _voice;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //レイを飛ばす
       ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.tag=="Clear")
            {
                //「いってらっしゃい」と言われる
                _voice.GetComponent<PlaySound>().voiceNumber = 6;
                
            }
            if (hit.collider.gameObject.tag == "Face")
            {
                //顔を見たら「おはよー」再生
                _voice.GetComponent<PlaySound>().voiceNumber = 4;
            }
            if (hit.collider.gameObject.tag == "Chest")
            {
                //胸を見たら「変態」の再生
                _voice.GetComponent<PlaySound>().voiceNumber = 5;
            }
        }
    }
}
