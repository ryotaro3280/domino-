using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kama1 : MonoBehaviour {

	float minAngle = 0.0F;
	float maxAngle = 180.0F;
	float TimeCount = 5;

	void Start () {
		junbi ();
	}

	void junbi() {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle, 0, 0);
	}

	void Update() {
		TimeCount -= Time.deltaTime;

		if (TimeCount <= 0) {
			Debug.Log ("実行されてるよ");
			kiru ();
			TimeCount = 4;
		}
	}

	void kiru() {
		float minAngle = 180.0F;
		float maxAngle = 360.0F;
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle,0,0);
	}







}