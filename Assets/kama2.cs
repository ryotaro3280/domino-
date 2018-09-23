using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kama2 : MonoBehaviour {
	float t = 0.0f;
	float TimeCount = 5;

	// Use this for initialization
	void Start () {
		float minAngle = 0.0F;
		float maxAngle = 180.0F;
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle, 0, 0);
	}
	// Update is called once per frame
		void Update() {
			TimeCount -= Time.deltaTime;
			Debug.Log (t);
			t += 0.5f * Time.deltaTime;

			if (TimeCount <= 0) {
				Debug.Log ("実行されてるよ");
				TimeCount = 4;
				t = 0.0f;

			}
			kiru2 ();
		}
	void kiru2 () {
		float minAngle = 0.0F;
		float maxAngle = 180.0F;
		float angle = Mathf.LerpAngle (minAngle, maxAngle, t);
		transform.eulerAngles = new Vector3 (-angle, 0, 0);
	}
}
