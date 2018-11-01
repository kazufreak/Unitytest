using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    int speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            this.speed = 20;
            for(float i = 0; i < speed; i += 0.001f)
            {
                transform.Rotate(0, 0, i);
            }
            
        }
		
	}
}
