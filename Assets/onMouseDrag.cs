﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseDrag : MonoBehaviour {

	public Renderer rend;
	void Start() {
		rend = GetComponent<Renderer>();
	}
	void OnMouseDrag() {
		rend.material.color -= Color.white * Time.deltaTime;
	}

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}
}
