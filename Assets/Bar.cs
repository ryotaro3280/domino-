using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

	// Use this for initialization
	void Start () { //一回
		
	}
	
	// Update is called once per frame
	void Update () { //繰り返し
		//ここ↓から
		transform.Rotate(0f,0f,-0.1f);
		//ここ↑まで
		//コマンド＋B＝エラーか、わかる！！
	}
}
