using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kama1 : MonoBehaviour {

	void Start () {
	}
	float minAngle = 0.0F;
	float maxAngle = 180.0F;
	// Update is called once per frame
			void Update() {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle, 0, 0);
		kiru1 ();
	}
		void kiru1() {
		Debug.Log (1);
		float minAngle = 180.0F;
		float maxAngle = 360.0F;
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle,0,0);
		}
}