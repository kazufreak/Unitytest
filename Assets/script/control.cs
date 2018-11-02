using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    float speed = 0f;
    float ke = 0.96f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 20;
            
        }
   
        transform.Rotate(0, 0, speed);
        this.speed *= ke;



    }
}
