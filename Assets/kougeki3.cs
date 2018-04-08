using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kougeki3 : MonoBehaviour {

	// Use this for initialization

	private Vector3 initialPosition;//

	void Start () {
		initialPosition = transform.position;//
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(initialPosition.x, initialPosition.y, Mathf.Sin(Time.time) * -20.0f + initialPosition.z);//
		//transform.position += transform.up * -0.15f;
	}
}

