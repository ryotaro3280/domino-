using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenmetu3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		Invoke ("Akanigou", 2f);
	}
	void Akanigou () {
		gameObject.SetActive (true);
		Invoke ("Akaniban", 1f);
	}
	void Akaniban () {
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
