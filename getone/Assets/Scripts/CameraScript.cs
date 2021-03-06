﻿// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    // Object to track.
    public Transform focus = null;

	void Start () {
        // Find a Ball object automatically.
        GameObject obj = GameObject.FindWithTag("Ball");
        if (obj != null) {
            focus = obj.transform;
        }
	}
	
	void Update () {
        if (focus != null) {
            // Track the object.
            float z = transform.position.z;
            transform.position = new Vector3(focus.position.x, focus.position.y, z);
        }
	}
}
