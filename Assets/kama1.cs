using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kama1 : MonoBehaviour {

	float minAngle = 0.0F;
	float maxAngle = 180.0F;
	float TimeCount = 5;
	float t = 0.0f;
	float a = 0f;

	void Start () {
		Invoke ("junbi", 3f);
		Invoke ("Update", 3f);
	}

	void junbi() {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle, 0, 0);
	}

	void Update() {
		a += 1;
		if (a > 60) {
			TimeCount -= Time.deltaTime;
			t += 0.5f * Time.deltaTime;

			if (TimeCount <= 0) {
				TimeCount = 4;
				t = 0.0f;

			}
			kiru ();
		}
	}

	void kiru() {
		float minAngle = 0.0F;
		float maxAngle = 180.0F;
		float angle = Mathf.LerpAngle (minAngle, maxAngle, t);
		transform.eulerAngles = new Vector3 (angle, 0, 0);
	}







}