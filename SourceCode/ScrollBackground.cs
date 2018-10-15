using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour {

    public float Speed = 0;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = new Vector2(Time.time * Speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
	}
}
