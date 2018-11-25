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
		//Debug.Log (rigid);
	}
	// Update is called once per frame
	void Update () {
		speed = rigid.velocity.magnitude;
		Debug.Log (speed);
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
		//if(speed > 0
			if (tag.gameObject.tag == "damage") {
				hp = hp - 6;
				Debug.Log (hp);

				GameOverText.GetComponent<Text> ().enabled = true;
			}
		}
}
