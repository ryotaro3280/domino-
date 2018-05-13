using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soul1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			transform.position += transform.up * 0.2f;
		}
		if (Input.GetKey ("right")) {
			transform.position += transform.right * 0.2f;
		}
		if (Input.GetKey ("left")) {
			transform.position += transform.right * -0.2f;
		}
		if (Input.GetKey ("down")) {
			transform.position += transform.up * -0.2f;
		}
	}
}
