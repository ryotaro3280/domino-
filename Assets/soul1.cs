using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soul1 : MonoBehaviour {
	int hp;

	// Use this for initialization
	void Start () {
		hp = 20;
		Debug.Log (hp);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			transform.position += transform.up * 0.2f;
		}
		if (Input.GetKey ("right")) {
			transform.position += transform.right * 0.2f;
		}
		if (Input.GetKey ("left")) {
			transform.position += transform.right * -0.2f;
		}
		if (Input.GetKey ("down")) {
			transform.position += transform.up * -0.2f;
		}
	}

	void OnTriggerEnter(Collider tag){
		if (tag.gameObject.tag == "damage") {
			Debug.Log ("ok");
			hp = hp - 6;
			Debug.Log (hp);
		}
	}
}
