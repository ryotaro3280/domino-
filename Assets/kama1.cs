using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kama1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//for (int i=0;i<120;i++) {
			//transform.Rotate (3f, 0f, 0f);
		//}
	}
	float minAngle = 0.0F;
	float maxAngle = 90.0F;
	// Update is called once per frame
			void Update() {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle, 0, 0);
		Invoke ("kiru1", 1f);
	}
		void kiru1() {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle,0,0);
			Invoke ("kiru2", 1f);
		}
		void kiru2() {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle,0,0);
			Invoke ("kiru3", 1f);
		}
		void kiru3() {
		float angle = Mathf.LerpAngle (minAngle, maxAngle, Time.time);
		transform.eulerAngles = new Vector3 (angle,0,0);
		}
}