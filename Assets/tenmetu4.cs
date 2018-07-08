using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenmetu4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		Invoke ("Aonigou", 3f);
	}
	void Aonigou () {
		gameObject.SetActive (true);
		Invoke ("Aosanban", 1f);
	}
	void Aosanban () {
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
