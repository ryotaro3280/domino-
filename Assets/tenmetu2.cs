using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenmetu2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		Invoke ("Ao", 1f);
	}
	void Ao () {
		gameObject.SetActive (true);
		Invoke ("Aoniban", 1f);
	}
	void Aoniban () {
		gameObject.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
