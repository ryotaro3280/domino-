using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ketuioidakituzukerunnda : MonoBehaviour {
	public GameObject GameOverText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col){
			GameOverText.GetComponent<Text> ().enabled = true;
	}
}
