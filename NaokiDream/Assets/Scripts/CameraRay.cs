using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour {


    private Ray ray;
    
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
                print("OK");
            }
        }
    }
}
