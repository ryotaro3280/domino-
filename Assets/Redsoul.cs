using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Redsoul : MonoBehaviour {
	public static bool moveup;
	public static bool movedown;
	public static bool move;
	public float speed;
	public Rigidbody rigid;
	public GameObject GameOverText;
	int hp;


	// Use this for initialization
	void Start () {
		rigid = GameObject.Find("Redsoul").GetComponent<Rigidbody>();
		hp = 20;
	}
	// Update is called once per frame
	void Update () {
		if (hp < 1) {
			GameOverText.GetComponent<Text> ().enabled = true;
		}
		speed = rigid.velocity.magnitude;
		Debug.Log (speed);
		if (Input.GetKey ("up")) {
			transform.position += transform.up * 0.5f;
		}
		if (Input.GetKey ("right")) {
			transform.position += transform.right * 0.5f;
		}
		if (Input.GetKey ("left")) {
			transform.position += transform.right * -0.5f;
		}
		if (Input.GetKey ("down")) {
			transform.position += transform.up * -0.5f;
		}
	}

	void OnTriggerEnter(Collider tag){
		if ((tag.gameObject.tag == "Bluedamage") && (speed > 0f)) {
			hp = hp - 6;
		}
		if ((tag.gameObject.tag == "Bluedamage") && (speed == 0f)) {
			hp = hp - 0;
		}
		if ((tag.gameObject.tag == "Orangedamage") && (speed == 0f)) {
			hp = hp - 6;
		}
		if ((tag.gameObject.tag == "Orangedamage") && (speed > 0f)) {
			hp = hp - 0;
		}

	}
}
