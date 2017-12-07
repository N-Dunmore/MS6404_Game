using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_Camera_Update : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.position = gameObject.transform.parent.position;

	}
}
