﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kougeki1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position += transform.up * -0.15f;
	}
}