﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velociade : MonoBehaviour {

	public float speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
	}
}
