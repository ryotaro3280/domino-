﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kama1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i=0;i<120;i++) {
			transform.Rotate (3f, 0f, 0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
