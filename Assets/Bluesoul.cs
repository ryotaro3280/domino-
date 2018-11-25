using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluesoul : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			transform.position += transform.up * 0.45f;
		}
		if (Input.GetKey ("right")) {
			transform.position += transform.right * 0.1f;
		}
		if (Input.GetKey ("left")) {
			transform.position += transform.right * -0.1f;
		}
	}
}
