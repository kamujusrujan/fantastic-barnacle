﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	// Use this for initialization

	public int speed;


	// Update is called once per frame
	void Update () {
		transform.Translate (transform.forward * speed * Time.deltaTime);
	}
}
