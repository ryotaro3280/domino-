using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kama2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float minAngle = 0.0F;
	float maxAngle = 180.0F;
	// Update is called once per frame
	void Update () {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (-angle, 0, 0);
		kiru2 ();
	}
	void kiru2 () {
		float minAngle = 180.0F;
		float maxAngle = 360.0F;
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (-angle, 0, 0);
	}
}
