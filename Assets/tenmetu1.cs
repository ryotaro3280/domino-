using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenmetu1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);
		Invoke ("Aka", 1f);
	}
	void Aka () {
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
